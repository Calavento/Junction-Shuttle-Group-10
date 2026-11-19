<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceipt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceipt))
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        lblReference = New Label()
        Panel2 = New Panel()
        lblPayment = New Label()
        lblSeats = New Label()
        lblPassenger = New Label()
        lblStops = New Label()
        lblDeparture = New Label()
        lblDate = New Label()
        lblRoute = New Label()
        Panel3 = New Panel()
        lblFare = New Label()
        btnClose = New Button()
        btnCancel = New Button()
        ToolTip1 = New ToolTip(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Peru
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(786, 153)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(9, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(274, 38)
        Label1.TabIndex = 1
        Label1.Text = "Booking Confirmed"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gold
        Label2.Location = New Point(9, 20)
        Label2.Name = "Label2"
        Label2.Size = New Size(363, 48)
        Label2.TabIndex = 2
        Label2.Text = "JUNCTION SHUTTLE"
        ' 
        ' lblReference
        ' 
        lblReference.AutoSize = True
        lblReference.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblReference.Location = New Point(3, 7)
        lblReference.Name = "lblReference"
        lblReference.Size = New Size(107, 28)
        lblReference.TabIndex = 3
        lblReference.Text = "Reference"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lblPayment)
        Panel2.Controls.Add(lblSeats)
        Panel2.Controls.Add(lblPassenger)
        Panel2.Controls.Add(lblStops)
        Panel2.Controls.Add(lblDeparture)
        Panel2.Controls.Add(lblDate)
        Panel2.Controls.Add(lblRoute)
        Panel2.Controls.Add(lblReference)
        Panel2.Location = New Point(13, 178)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(761, 394)
        Panel2.TabIndex = 4
        ' 
        ' lblPayment
        ' 
        lblPayment.AutoSize = True
        lblPayment.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPayment.Location = New Point(3, 280)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New Size(95, 28)
        lblPayment.TabIndex = 13
        lblPayment.Text = "Payment"
        ' 
        ' lblSeats
        ' 
        lblSeats.AutoSize = True
        lblSeats.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeats.Location = New Point(3, 241)
        lblSeats.Name = "lblSeats"
        lblSeats.Size = New Size(76, 28)
        lblSeats.TabIndex = 10
        lblSeats.Text = "Seat(s)"
        ' 
        ' lblPassenger
        ' 
        lblPassenger.AutoSize = True
        lblPassenger.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPassenger.Location = New Point(3, 202)
        lblPassenger.Name = "lblPassenger"
        lblPassenger.Size = New Size(107, 28)
        lblPassenger.TabIndex = 9
        lblPassenger.Text = "Passenger"
        ' 
        ' lblStops
        ' 
        lblStops.AutoSize = True
        lblStops.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStops.Location = New Point(3, 163)
        lblStops.Name = "lblStops"
        lblStops.Size = New Size(34, 28)
        lblStops.TabIndex = 8
        lblStops.Text = "To"
        ' 
        ' lblDeparture
        ' 
        lblDeparture.AutoSize = True
        lblDeparture.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDeparture.Location = New Point(3, 124)
        lblDeparture.Name = "lblDeparture"
        lblDeparture.Size = New Size(109, 28)
        lblDeparture.TabIndex = 6
        lblDeparture.Text = "Departure"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDate.Location = New Point(3, 85)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(57, 28)
        lblDate.TabIndex = 5
        lblDate.Text = "Date"
        ' 
        ' lblRoute
        ' 
        lblRoute.AutoSize = True
        lblRoute.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRoute.Location = New Point(3, 46)
        lblRoute.Name = "lblRoute"
        lblRoute.Size = New Size(68, 28)
        lblRoute.TabIndex = 4
        lblRoute.Text = "Route"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Goldenrod
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(lblFare)
        Panel3.Location = New Point(13, 503)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(763, 69)
        Panel3.TabIndex = 12
        ' 
        ' lblFare
        ' 
        lblFare.AutoSize = True
        lblFare.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFare.Location = New Point(14, 16)
        lblFare.Name = "lblFare"
        lblFare.Size = New Size(131, 32)
        lblFare.TabIndex = 11
        lblFare.Text = "Fare : GH₵"
        ToolTip1.SetToolTip(lblFare, "Total Amount /Fare.")
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.DarkBlue
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(652, 579)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(122, 80)
        btnClose.TabIndex = 5
        btnClose.Text = "CLOSE"
        ToolTip1.SetToolTip(btnClose, "Click on it to close.")
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.LemonChiffon
        btnCancel.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(512, 579)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(122, 80)
        btnCancel.TabIndex = 6
        btnCancel.Text = "CANCEL BOOKING"
        ToolTip1.SetToolTip(btnCancel, "Click on it to cancel the Booking.")
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' frmReceipt
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        BackgroundImageLayout = ImageLayout.Stretch
        CancelButton = btnCancel
        ClientSize = New Size(788, 672)
        Controls.Add(btnCancel)
        Controls.Add(Panel3)
        Controls.Add(btnClose)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmReceipt"
        StartPosition = FormStartPosition.CenterParent
        Text = "Booking receipt"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblReference As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblFare As Label
    Friend WithEvents lblSeats As Label
    Friend WithEvents lblPassenger As Label
    Friend WithEvents lblStops As Label
    Friend WithEvents lblDeparture As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblRoute As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblPayment As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
