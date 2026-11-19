Public Class frmReceipt
    Public CancelRequested As Boolean = False
    Public BookingRef As String

    Public Sub ShowBooking(ref As String, route As String, tripDate As String,
                       departure As String, boarding As String, dropoff As String,
                       passenger As String, seats As String,
                       fare As Double, payment As String)

        BookingRef = ref


        lblReference.Text = "Reference: " & ref
        lblRoute.Text = "Route: " & route
        lblDate.Text = "Date: " & tripDate
        lblDeparture.Text = "Departure: " & departure
        lblStops.Text = "From: " & boarding & " to " & dropoff
        lblPassenger.Text = "Passenger: " & passenger
        lblSeats.Text = "Seat(s): " & seats
        lblFare.Text = "Fare: GH₵ " & fare.ToString("0.00")
        lblPayment.Text = "Payment: " & payment
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim answer As DialogResult = MessageBox.Show("Cancel booking " & BookingRef & "?",
                                                 "Cancel booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = DialogResult.Yes Then
            CancelRequested = True
            Me.Close()
        End If
    End Sub

End Class