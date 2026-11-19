Public Class frmManifest

    Public Sub New(allBookings As List(Of Booking), route As String, tripDate As String, departure As String)
        InitializeComponent()

        lblTrip.Text = $"{route}   |   {tripDate}   |   {departure}"

        Dim trip = allBookings.Where(Function(b) b.Route = route AndAlso b.TripDate = tripDate AndAlso b.Departure = departure).ToList()

        Dim totalSeats As Integer = 0
        Dim totalFare As Double = 0
        For Each b In trip
            dgvManifest.Rows.Add(b.Ref, b.Passenger, b.Phone,
                                 String.Join(", ", b.Seats.OrderBy(Function(s) s)),
                                 b.Boarding, b.Dropoff, b.Fare.ToString("0.00"), b.Payment)
            totalSeats += b.Seats.Count
            totalFare += b.Fare
        Next

        lblSummary.Text = $"Bookings: {trip.Count}   |   Seats booked: {totalSeats}   |   Total fare: GH₵ {totalFare:0.00}"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Function BuildManifestText() As String
        Dim sb As New System.Text.StringBuilder()
        sb.AppendLine("DRIVER MANIFEST - " & DateTime.Now.ToString("dd MMM yyyy HH:mm"))
        sb.AppendLine("------------------------------")
        For Each row As DataGridViewRow In dgvManifest.Rows
            If Not row.IsNewRow Then
                sb.AppendLine(row.Cells(0).Value & " | " &
                              row.Cells(1).Value & " | " &
                              row.Cells(2).Value & " | Seats: " &
                              row.Cells(3).Value & " | " &
                              row.Cells(4).Value & " -> " &
                              row.Cells(5).Value & " | GHC " &
                              row.Cells(6).Value & " | " &
                              row.Cells(7).Value)
            End If
        Next
        Return sb.ToString()
    End Function
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim driverPhone As String = "233XXXXXXXXX" ' replace with the driver's number: country code, no + or leading 0
        Dim url As String = "https://wa.me/" & driverPhone &
                            "?text=" & Uri.EscapeDataString(BuildManifestText())
        Process.Start(New ProcessStartInfo(url) With {.UseShellExecute = True})
    End Sub
End Class
