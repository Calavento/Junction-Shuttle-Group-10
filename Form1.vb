Imports System.Linq
Imports System.Text.RegularExpressions
Public Class Form1
    Private ReadOnly Navy As Color = ColorTranslator.FromHtml("#1F3A5F")
    Private ReadOnly Gold As Color = ColorTranslator.FromHtml("#F5B800")
    Private ReadOnly PageBg As Color = ColorTranslator.FromHtml("#EEF2F9")
    Private ReadOnly SeatFree As Color = ColorTranslator.FromHtml("#C6EBD3")
    Private ReadOnly SeatTaken As Color = ColorTranslator.FromHtml("#F0A8A8")
    Private ReadOnly TotalSeats As Integer = 15
    Private stopPrices As New Dictionary(Of String, Double)
    Private routeStops As String()
    Private Bookings As New List(Of Booking)
    Private intBookingCounter As Integer = 1000
    Dim intGhanaNumber As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuildSeatMap(New HashSet(Of Integer))
        stopPrices.Clear()
        stopPrices.Clear()
        stopPrices("Madina Zongo Junction") = 0.0
        stopPrices("Ritz Junction") = 4.0
        stopPrices("Adenta Barrier") = 5.0
        stopPrices("Frafraha") = 7.0
        stopPrices("Amrahia") = 9.0
        stopPrices("Malejor School Junction") = 10.0
        stopPrices("Foster Junction") = 11.0
        stopPrices("Valley View University Junction") = 12.5
        stopPrices("Oyibi") = 14.0
        stopPrices("Dodowa") = 18.0
    End Sub

    Private intTotalSeats As Integer = 15
    Private Sub BuildSeatMap(taken As HashSet(Of Integer))
        flpSeats.Controls.Clear()
        For seat As Integer = 1 To 15
            Dim b As New Button With {
            .Text = seat.ToString(),
            .Size = New Size(50, 40),
            .FlatStyle = FlatStyle.Flat,
            .Font = New Font("Segoe UI", 10, FontStyle.Bold),
            .Tag = seat,
             .TabStop = False
        }
            b.FlatAppearance.BorderSize = 0
            b.BackColor = If(taken.Contains(seat), SeatTaken, SeatFree)
            b.ForeColor = If(taken.Contains(seat), Color.DarkRed, Color.DarkGreen)

            AddHandler b.Click, AddressOf SeatButton_Click

            flpSeats.Controls.Add(b)
        Next
        lblSeatsLeft.Text = "Seats left on this segment: " & (intTotalSeats - taken.Count)
    End Sub
    Private Function GetTakenSeats() As HashSet(Of Integer)
        Dim taken As New HashSet(Of Integer)
        If routeStops Is Nothing OrElse cboBoarding.SelectedIndex = -1 OrElse cboDropOff.SelectedIndex = -1 Then Return taken

        Dim strDate As String = dtpDate.Value.ToString("yyyy-MM-dd")
        Dim intFrom As Integer = Array.IndexOf(routeStops, cboBoarding.Text)
        Dim intTo As Integer = Array.IndexOf(routeStops, cboDropOff.Text)

        For Each b In bookings
            If b.Route = cboRoute.Text AndAlso b.TripDate = strDate AndAlso b.Departure = cboTime.Text Then
                Dim intBookedFrom As Integer = Array.IndexOf(routeStops, b.Boarding)
                Dim intBookedTo As Integer = Array.IndexOf(routeStops, b.Dropoff)
                If intBookedFrom < intTo AndAlso intBookedTo > intFrom Then
                    For Each seat In b.Seats
                        taken.Add(seat)
                    Next
                End If
            End If
        Next
        Return taken
    End Function

    Private selectedSeats As New List(Of Integer)
    Private Sub SeatButton_Click(sender As Object, e As EventArgs)
        btnBookSeat.Focus()

        Dim b As Button = DirectCast(sender, Button)
        Dim seat As Integer = CInt(b.Tag)

        If b.BackColor = SeatTaken Then Return

        If selectedSeats.Contains(seat) Then
            selectedSeats.Remove(seat)
            b.BackColor = SeatFree
        Else
            selectedSeats.Add(seat)
            b.BackColor = Gold
        End If

    End Sub

    Dim dblFare As Double
    Private Sub UpdateFare()
        If cboBoarding.SelectedIndex = -1 OrElse cboDropOff.SelectedIndex = -1 Then Return

        Dim strFrom As String = cboBoarding.Text
        Dim strTo As String = cboDropOff.Text

        If Not stopPrices.ContainsKey(strFrom) OrElse Not stopPrices.ContainsKey(strTo) Then
            lblFare.Text = "Fare: price not set"
            dblFare = 0
            Return
        End If

        Dim dblPerSeat As Double = Math.Abs(stopPrices(strTo) - stopPrices(strFrom))

        dblFare = dblPerSeat * CDbl(nudSeats.Value)


        lblFare.Text = "Fare: GH₵ " & dblFare.ToString("0.00")
    End Sub

    Private Sub nudSeats_ValueChanged(sender As Object, e As EventArgs) Handles nudSeats.ValueChanged
        UpdateFare()
    End Sub

    Private Sub cboDropOff_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDropOff.SelectedIndexChanged
        UpdateFare()
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso
         e.KeyChar <> " "c AndAlso
         e.KeyChar <> "-"c AndAlso
         e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cboRoutes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoute.SelectedIndexChanged
        routeStops = {"Madina Zongo Junction", "Ritz Junction", "Adenta Barrier", "Frafraha", "Amrahia", "Malejor School Junction", "Foster Junction", "Valley View University Junction", "Oyibi", "Dodowa"}

        cboBoarding.Items.Clear()
        cboDropOff.Items.Clear()

        cboBoarding.Items.Add(routeStops(0))

        For i As Integer = 1 To routeStops.Length - 1
            cboDropOff.Items.Add(routeStops(i))
        Next

        cboBoarding.SelectedIndex = 0
        cboDropOff.SelectedIndex = 0
        UpdateFare()
    End Sub

    Private Function IsGhanaNumber(phone As String) As Boolean
        Return Regex.IsMatch(phone, "^0(20|23|24|25|26|27|28|50|53|54|55|56|57|59)\d{7}$")
    End Function
    Private Sub btnBookSeat_Click(sender As Object, e As EventArgs) Handles btnBookSeat.Click
        If txtname.Text.Trim().Length < 2 OrElse Not Regex.IsMatch(txtname.Text.Trim(), "^[\p{L}][\p{L} \-']*$") Then
            MessageBox.Show("Enter the passenger's name using letters only.", "Invalid name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtname.Focus()
            Return
        End If

        If Not IsGhanaNumber(txtPhone.Text) Then
            MessageBox.Show("Enter a valid Ghana mobile number, for example 0244123456.", "Invalid phone number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPhone.Focus()
            Return
        End If

        If cboBoarding.SelectedIndex = -1 OrElse cboDropOff.SelectedIndex = -1 Then
            MessageBox.Show("Choose the boarding and drop-off stops.", "Missing stops", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If selectedSeats.Count <> CInt(nudSeats.Value) Then
            MessageBox.Show("Please select exactly " & nudSeats.Value & " seat(s) on the seat map.", "Seat selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        intBookingCounter += 1
        Dim strRef As String = "B" & intBookingCounter
        Dim strName As String = System.Globalization.CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txtname.Text.Trim().ToLower())
        Dim strDate As String = dtpDate.Value.ToString("yyyy-MM-dd")
        Dim strSeats As String = String.Join(" ", selectedSeats.OrderBy(Function(s) s))

        Bookings.Add(New Booking With {
            .Ref = strRef,
            .Route = cboRoute.Text,
            .TripDate = strDate,
            .Departure = cboTime.Text,
            .Boarding = cboBoarding.Text,
            .Dropoff = cboDropOff.Text,
            .Passenger = strName,
            .Phone = txtPhone.Text,
            .Seats = New List(Of Integer)(selectedSeats),
            .Fare = dblFare,
            .Payment = cboPayment.Text
        })

        selectedSeats.Clear()
        BuildSeatMap(GetTakenSeats())

        Dim receipt As New frmReceipt()
        receipt.ShowBooking(strRef, cboRoute.Text, strDate, cboTime.Text, cboBoarding.Text,
                            cboDropOff.Text, strName, strSeats, dblFare, cboPayment.Text)
        receipt.ShowDialog(Me)

        If receipt.CancelRequested Then
            Dim target As Booking = Bookings.FirstOrDefault(Function(b) b.Ref = receipt.BookingRef)
            If target IsNot Nothing Then Bookings.Remove(target)

            BuildSeatMap(GetTakenSeats())
            MessageBox.Show("Booking " & receipt.BookingRef & " has been cancelled.", "Cancelled",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Passenger details
        txtname.Clear()
        txtPhone.Clear()
        nudSeats.Value = 1
        cboPayment.SelectedIndex = 0

        ' Trip details
        cboRoute.SelectedIndex = 0
        cboBoarding.SelectedIndex = 0
        cboDropOff.SelectedIndex = 0

        ' Seat selection
        selectedSeats.Clear()
        BuildSeatMap(GetTakenSeats())

        UpdateFare()
        txtname.Focus()
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        If txtPhone.Text.Length > 0 AndAlso Not IsGhanaNumber(txtPhone.Text) Then
            txtPhone.BackColor = Color.MistyRose
        Else
            txtPhone.BackColor = Color.White
        End If
    End Sub

    Private Sub btnDriverManifest_Click(sender As Object, e As EventArgs) Handles btnDriverManifest.Click
        Dim strDate As String = dtpDate.Value.ToString("yyyy-MM-dd")

        Dim frm As New frmManifest(Bookings, cboRoute.Text, strDate, cboTime.Text)
        frm.ShowDialog(Me)
    End Sub
End Class
