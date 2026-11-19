<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        dtpDate = New DateTimePicker()
        cboDropOff = New ComboBox()
        cboBoarding = New ComboBox()
        cboTime = New ComboBox()
        cboRoute = New ComboBox()
        Lbldropoff = New Label()
        Lblpickup = New Label()
        LblDeparturetime = New Label()
        Lbltraveldate = New Label()
        Lblroute = New Label()
        Label3 = New Label()
        Panel3 = New Panel()
        nudSeats = New NumericUpDown()
        cboPayment = New ComboBox()
        txtPhone = New TextBox()
        txtname = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Panel4 = New Panel()
        lblFare = New Label()
        Label14 = New Label()
        flpSeats = New FlowLayoutPanel()
        lblSeatsLeft = New Label()
        Label10 = New Label()
        btnClear = New Button()
        btnBookSeat = New Button()
        btnDriverManifest = New Button()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(nudSeats, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Peru
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1310, 140)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.bus_in_the_street_free_photo
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(189, 140)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(195, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(390, 38)
        Label2.TabIndex = 1
        Label2.Text = "Book a seat. Skip the queue."
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.FlatStyle = FlatStyle.Flat
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(195, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 48)
        Label1.TabIndex = 0
        Label1.Text = "Junction Shuttle"
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(dtpDate)
        Panel2.Controls.Add(cboDropOff)
        Panel2.Controls.Add(cboBoarding)
        Panel2.Controls.Add(cboTime)
        Panel2.Controls.Add(cboRoute)
        Panel2.Controls.Add(Lbldropoff)
        Panel2.Controls.Add(Lblpickup)
        Panel2.Controls.Add(LblDeparturetime)
        Panel2.Controls.Add(Lbltraveldate)
        Panel2.Controls.Add(Lblroute)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(12, 157)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(642, 291)
        Panel2.TabIndex = 1
        ' 
        ' dtpDate
        ' 
        dtpDate.CalendarFont = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpDate.CalendarMonthBackground = Color.Thistle
        dtpDate.CalendarTitleBackColor = Color.Thistle
        dtpDate.Location = New Point(255, 103)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(380, 34)
        dtpDate.TabIndex = 11
        ' 
        ' cboDropOff
        ' 
        cboDropOff.BackColor = Color.Thistle
        cboDropOff.DropDownStyle = ComboBoxStyle.DropDownList
        cboDropOff.FlatStyle = FlatStyle.Popup
        cboDropOff.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboDropOff.FormattingEnabled = True
        cboDropOff.Items.AddRange(New Object() {"Madina Zongo Junction", "Ritz Junction", "Adenta Barrier", "Frafraha", "Amrahia", "Malejor School Junction", "Foster Junction", "Valley View University Junction", "Oyibi", "Dodowa"})
        cboDropOff.Location = New Point(255, 240)
        cboDropOff.Name = "cboDropOff"
        cboDropOff.Size = New Size(380, 36)
        cboDropOff.TabIndex = 10
        ToolTip1.SetToolTip(cboDropOff, "Where would the passenger drop off.")
        ' 
        ' cboBoarding
        ' 
        cboBoarding.BackColor = Color.Thistle
        cboBoarding.DropDownStyle = ComboBoxStyle.DropDownList
        cboBoarding.FlatStyle = FlatStyle.Popup
        cboBoarding.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboBoarding.FormattingEnabled = True
        cboBoarding.Items.AddRange(New Object() {"Madina Zongo Junction"})
        cboBoarding.Location = New Point(255, 194)
        cboBoarding.Name = "cboBoarding"
        cboBoarding.Size = New Size(380, 36)
        cboBoarding.TabIndex = 9
        ToolTip1.SetToolTip(cboBoarding, "Pickup Junction.")
        ' 
        ' cboTime
        ' 
        cboTime.BackColor = Color.Thistle
        cboTime.DropDownStyle = ComboBoxStyle.DropDownList
        cboTime.FlatStyle = FlatStyle.Popup
        cboTime.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboTime.FormattingEnabled = True
        cboTime.Items.AddRange(New Object() {"6:00 AM", "6:30 AM", "7:00 AM", "7:30 AM", "8:00 AM", "8:30 AM", "4:00 PM", "4:30 PM", "5:00 PM", "5:30 PM", "6:00 PM", "6:30 PM", "7:00 PM", "7:30 PM", "8:00 PM", "8:30 PM"})
        cboTime.Location = New Point(255, 148)
        cboTime.Name = "cboTime"
        cboTime.Size = New Size(380, 36)
        cboTime.TabIndex = 8
        ToolTip1.SetToolTip(cboTime, "When will you the passenger be picked.")
        ' 
        ' cboRoute
        ' 
        cboRoute.BackColor = Color.Thistle
        cboRoute.DropDownStyle = ComboBoxStyle.DropDownList
        cboRoute.FlatStyle = FlatStyle.Popup
        cboRoute.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboRoute.FormattingEnabled = True
        cboRoute.Items.AddRange(New Object() {"MADINA - DODOWA"})
        cboRoute.Location = New Point(255, 56)
        cboRoute.Name = "cboRoute"
        cboRoute.Size = New Size(380, 36)
        cboRoute.TabIndex = 6
        ' 
        ' Lbldropoff
        ' 
        Lbldropoff.AutoSize = True
        Lbldropoff.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbldropoff.Location = New Point(3, 248)
        Lbldropoff.Name = "Lbldropoff"
        Lbldropoff.Size = New Size(155, 30)
        Lbldropoff.TabIndex = 5
        Lbldropoff.Text = "Drop-off stop"
        ' 
        ' Lblpickup
        ' 
        Lblpickup.AutoSize = True
        Lblpickup.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblpickup.Location = New Point(3, 199)
        Lblpickup.Name = "Lblpickup"
        Lblpickup.Size = New Size(246, 30)
        Lblpickup.TabIndex = 4
        Lblpickup.Text = "Boarding stop(pickup)"
        ' 
        ' LblDeparturetime
        ' 
        LblDeparturetime.AutoSize = True
        LblDeparturetime.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblDeparturetime.Location = New Point(3, 157)
        LblDeparturetime.Name = "LblDeparturetime"
        LblDeparturetime.Size = New Size(177, 30)
        LblDeparturetime.TabIndex = 3
        LblDeparturetime.Text = "Departure Time"
        ' 
        ' Lbltraveldate
        ' 
        Lbltraveldate.AutoSize = True
        Lbltraveldate.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lbltraveldate.Location = New Point(3, 113)
        Lbltraveldate.Name = "Lbltraveldate"
        Lbltraveldate.Size = New Size(130, 30)
        Lbltraveldate.TabIndex = 2
        Lbltraveldate.Text = "Travel Date"
        ' 
        ' Lblroute
        ' 
        Lblroute.AutoSize = True
        Lblroute.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblroute.Location = New Point(3, 63)
        Lblroute.Name = "Lblroute"
        Lblroute.Size = New Size(73, 30)
        Lblroute.TabIndex = 1
        Lblroute.Text = "Route"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(3, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 30)
        Label3.TabIndex = 0
        Label3.Text = "Trip Details"
        ' 
        ' Panel3
        ' 
        Panel3.AutoSize = True
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(nudSeats)
        Panel3.Controls.Add(cboPayment)
        Panel3.Controls.Add(txtPhone)
        Panel3.Controls.Add(txtname)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(675, 158)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(636, 290)
        Panel3.TabIndex = 2
        ' 
        ' nudSeats
        ' 
        nudSeats.BackColor = Color.RosyBrown
        nudSeats.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        nudSeats.Location = New Point(210, 145)
        nudSeats.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        nudSeats.Name = "nudSeats"
        nudSeats.ReadOnly = True
        nudSeats.Size = New Size(194, 34)
        nudSeats.TabIndex = 10
        ToolTip1.SetToolTip(nudSeats, "How many seats does the passenger want to book?")
        nudSeats.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' cboPayment
        ' 
        cboPayment.BackColor = Color.RosyBrown
        cboPayment.DropDownStyle = ComboBoxStyle.DropDownList
        cboPayment.FlatStyle = FlatStyle.Popup
        cboPayment.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cboPayment.FormattingEnabled = True
        cboPayment.Items.AddRange(New Object() {"MTN MoMo", "Telecel Cash", "ATMoney", "Physical payment"})
        cboPayment.Location = New Point(210, 190)
        cboPayment.Name = "cboPayment"
        cboPayment.Size = New Size(419, 36)
        cboPayment.TabIndex = 9
        ToolTip1.SetToolTip(cboPayment, "Which payment method?")
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPhone.Location = New Point(210, 101)
        txtPhone.MaxLength = 10
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(419, 34)
        txtPhone.TabIndex = 7
        ToolTip1.SetToolTip(txtPhone, "Enter the passenger number.")
        ' 
        ' txtname
        ' 
        txtname.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtname.Location = New Point(210, 55)
        txtname.Name = "txtname"
        txtname.Size = New Size(419, 34)
        txtname.TabIndex = 6
        ToolTip1.SetToolTip(txtname, "Enter the Passenger name.")
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(13, 249)
        Label9.Name = "Label9"
        Label9.Size = New Size(275, 28)
        Label9.TabIndex = 5
        Label9.Text = "Minimum GH₵ 4.00 per seat."
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(13, 196)
        Label8.Name = "Label8"
        Label8.Size = New Size(174, 28)
        Label8.TabIndex = 4
        Label8.Text = "Payment method"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(13, 151)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 28)
        Label7.TabIndex = 3
        Label7.Text = "Seats(1-5)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(13, 106)
        Label6.Name = "Label6"
        Label6.Size = New Size(184, 28)
        Label6.TabIndex = 2
        Label6.Text = "Phone(024*******)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 59)
        Label5.Name = "Label5"
        Label5.Size = New Size(185, 30)
        Label5.TabIndex = 1
        Label5.Text = "Passenger Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(13, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(195, 30)
        Label4.TabIndex = 0
        Label4.Text = "Passenger Details"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lblFare)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(flpSeats)
        Panel4.Controls.Add(lblSeatsLeft)
        Panel4.Controls.Add(Label10)
        Panel4.Location = New Point(12, 477)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1295, 199)
        Panel4.TabIndex = 3
        ' 
        ' lblFare
        ' 
        lblFare.AutoSize = True
        lblFare.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFare.ForeColor = Color.DarkGoldenrod
        lblFare.Location = New Point(12, 77)
        lblFare.Name = "lblFare"
        lblFare.Size = New Size(156, 38)
        lblFare.TabIndex = 6
        lblFare.Text = "FARE: GH₵"
        ToolTip1.SetToolTip(lblFare, "Total amount or Fare")
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(663, 15)
        Label14.Name = "Label14"
        Label14.Size = New Size(514, 28)
        Label14.TabIndex = 5
        Label14.Text = "Seat map for the chosen stops(green=free, red=taken)"
        ' 
        ' flpSeats
        ' 
        flpSeats.BorderStyle = BorderStyle.Fixed3D
        flpSeats.Location = New Point(663, 62)
        flpSeats.Name = "flpSeats"
        flpSeats.Size = New Size(514, 117)
        flpSeats.TabIndex = 4
        ToolTip1.SetToolTip(flpSeats, "The number of seats available in the Bus.")
        ' 
        ' lblSeatsLeft
        ' 
        lblSeatsLeft.AutoSize = True
        lblSeatsLeft.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeatsLeft.Location = New Point(12, 150)
        lblSeatsLeft.Name = "lblSeatsLeft"
        lblSeatsLeft.Size = New Size(315, 32)
        lblSeatsLeft.TabIndex = 2
        lblSeatsLeft.Text = "Seats left on this segment:"
        ToolTip1.SetToolTip(lblSeatsLeft, "Number of seats left in the bus.")
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.MidnightBlue
        Label10.Location = New Point(12, 11)
        Label10.Name = "Label10"
        Label10.Size = New Size(295, 32)
        Label10.TabIndex = 0
        Label10.Text = "Fare and seat availability"
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Thistle
        btnClear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(377, 694)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(155, 76)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        ToolTip1.SetToolTip(btnClear, "To clear passenger details.")
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnBookSeat
        ' 
        btnBookSeat.BackColor = Color.Gold
        btnBookSeat.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBookSeat.ForeColor = Color.Navy
        btnBookSeat.Location = New Point(17, 697)
        btnBookSeat.Name = "btnBookSeat"
        btnBookSeat.Size = New Size(155, 75)
        btnBookSeat.TabIndex = 4
        btnBookSeat.Text = "Book Seat"
        ToolTip1.SetToolTip(btnBookSeat, "Press Enter Key to Book the seat for the passenger.")
        btnBookSeat.UseVisualStyleBackColor = False
        ' 
        ' btnDriverManifest
        ' 
        btnDriverManifest.BackColor = Color.DarkBlue
        btnDriverManifest.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDriverManifest.ForeColor = Color.White
        btnDriverManifest.Location = New Point(197, 697)
        btnDriverManifest.Name = "btnDriverManifest"
        btnDriverManifest.Size = New Size(155, 75)
        btnDriverManifest.TabIndex = 6
        btnDriverManifest.Text = "Driver Manifest"
        ToolTip1.SetToolTip(btnDriverManifest, "Click on it to view the Driver's Manifest.")
        btnDriverManifest.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AcceptButton = btnBookSeat
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        CancelButton = btnClear
        ClientSize = New Size(1310, 799)
        Controls.Add(btnClear)
        Controls.Add(btnDriverManifest)
        Controls.Add(btnBookSeat)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "JUNCTION SHUTTLE BOOKING"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(nudSeats, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Lbldropoff As Label
    Friend WithEvents Lblpickup As Label
    Friend WithEvents LblDeparturetime As Label
    Friend WithEvents Lbltraveldate As Label
    Friend WithEvents Lblroute As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cboDropOff As ComboBox
    Friend WithEvents cboBoarding As ComboBox
    Friend WithEvents cboTime As ComboBox
    Friend WithEvents cboRoute As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboPayment As ComboBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblSeatsLeft As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents flpSeats As FlowLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents lblFare As Label
    Friend WithEvents nudSeats As NumericUpDown
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBookSeat As Button
    Friend WithEvents btnDriverManifest As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents ToolTip1 As ToolTip

End Class
