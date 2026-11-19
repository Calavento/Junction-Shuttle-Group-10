<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmManifest
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManifest))
        pnlHeader = New Panel()
        lblTrip = New Label()
        lblTitle = New Label()
        dgvManifest = New DataGridView()
        colRef = New DataGridViewTextBoxColumn()
        colPassenger = New DataGridViewTextBoxColumn()
        colPhone = New DataGridViewTextBoxColumn()
        colSeats = New DataGridViewTextBoxColumn()
        colFrom = New DataGridViewTextBoxColumn()
        colTo = New DataGridViewTextBoxColumn()
        colFare = New DataGridViewTextBoxColumn()
        colPayment = New DataGridViewTextBoxColumn()
        lblSummary = New Label()
        btnClose = New Button()
        btnSend = New Button()
        ToolTip1 = New ToolTip(components)
        pnlHeader.SuspendLayout()
        CType(dgvManifest, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.Peru
        pnlHeader.Controls.Add(lblTrip)
        pnlHeader.Controls.Add(lblTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(1350, 123)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTrip
        ' 
        lblTrip.AutoSize = True
        lblTrip.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTrip.ForeColor = Color.White
        lblTrip.Location = New Point(15, 74)
        lblTrip.Name = "lblTrip"
        lblTrip.Size = New Size(53, 30)
        lblTrip.TabIndex = 1
        lblTrip.Text = "Trip"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.Navy
        lblTitle.Location = New Point(13, 11)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(336, 48)
        lblTitle.TabIndex = 0
        lblTitle.Text = "DRIVER MANIFEST"
        ' 
        ' dgvManifest
        ' 
        dgvManifest.AllowUserToAddRows = False
        dgvManifest.AllowUserToDeleteRows = False
        dgvManifest.AllowUserToResizeRows = False
        dgvManifest.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvManifest.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvManifest.BackgroundColor = Color.Snow
        dgvManifest.BorderStyle = BorderStyle.Fixed3D
        dgvManifest.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical
        dgvManifest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvManifest.Columns.AddRange(New DataGridViewColumn() {colRef, colPassenger, colPhone, colSeats, colFrom, colTo, colFare, colPayment})
        dgvManifest.Location = New Point(13, 140)
        dgvManifest.Name = "dgvManifest"
        dgvManifest.ReadOnly = True
        dgvManifest.RowHeadersVisible = False
        dgvManifest.RowHeadersWidth = 62
        dgvManifest.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvManifest.Size = New Size(1324, 426)
        dgvManifest.TabIndex = 1
        ToolTip1.SetToolTip(dgvManifest, "The Booking Record.")
        ' 
        ' colRef
        ' 
        colRef.HeaderText = "Ref"
        colRef.MinimumWidth = 8
        colRef.Name = "colRef"
        colRef.ReadOnly = True
        ' 
        ' colPassenger
        ' 
        colPassenger.FillWeight = 140F
        colPassenger.HeaderText = "Passenger"
        colPassenger.MinimumWidth = 8
        colPassenger.Name = "colPassenger"
        colPassenger.ReadOnly = True
        ' 
        ' colPhone
        ' 
        colPhone.HeaderText = "Phone"
        colPhone.MinimumWidth = 8
        colPhone.Name = "colPhone"
        colPhone.ReadOnly = True
        ' 
        ' colSeats
        ' 
        colSeats.FillWeight = 70F
        colSeats.HeaderText = "Seat(s)"
        colSeats.MinimumWidth = 8
        colSeats.Name = "colSeats"
        colSeats.ReadOnly = True
        ' 
        ' colFrom
        ' 
        colFrom.FillWeight = 140F
        colFrom.HeaderText = "Boarding"
        colFrom.MinimumWidth = 8
        colFrom.Name = "colFrom"
        colFrom.ReadOnly = True
        ' 
        ' colTo
        ' 
        colTo.FillWeight = 140F
        colTo.HeaderText = "Drop-off"
        colTo.MinimumWidth = 8
        colTo.Name = "colTo"
        colTo.ReadOnly = True
        ' 
        ' colFare
        ' 
        colFare.FillWeight = 80F
        colFare.HeaderText = "Fare (GH₵)"
        colFare.MinimumWidth = 8
        colFare.Name = "colFare"
        colFare.ReadOnly = True
        ' 
        ' colPayment
        ' 
        colPayment.HeaderText = "Payment"
        colPayment.MinimumWidth = 8
        colPayment.Name = "colPayment"
        colPayment.ReadOnly = True
        ' 
        ' lblSummary
        ' 
        lblSummary.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblSummary.AutoSize = True
        lblSummary.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSummary.ForeColor = Color.MidnightBlue
        lblSummary.Location = New Point(13, 588)
        lblSummary.Name = "lblSummary"
        lblSummary.Size = New Size(123, 32)
        lblSummary.TabIndex = 2
        lblSummary.Text = "Summary"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClose.BackColor = Color.DarkBlue
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(1215, 579)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(122, 55)
        btnClose.TabIndex = 3
        btnClose.Text = "CLOSE"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' btnSend
        ' 
        btnSend.BackColor = Color.DarkCyan
        btnSend.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSend.ForeColor = Color.White
        btnSend.Location = New Point(1051, 579)
        btnSend.Name = "btnSend"
        btnSend.Size = New Size(122, 55)
        btnSend.TabIndex = 4
        btnSend.Text = "SEND"
        ToolTip1.SetToolTip(btnSend, "Click on it to send the Driver manifest to the Driver on Whatsapp.")
        btnSend.UseVisualStyleBackColor = False
        ' 
        ' frmManifest
        ' 
        AcceptButton = btnSend
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        CancelButton = btnClose
        ClientSize = New Size(1350, 650)
        Controls.Add(btnSend)
        Controls.Add(btnClose)
        Controls.Add(lblSummary)
        Controls.Add(dgvManifest)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmManifest"
        StartPosition = FormStartPosition.CenterParent
        Text = "Driver manifest"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        CType(dgvManifest, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblTrip As Label
    Friend WithEvents dgvManifest As DataGridView
    Friend WithEvents colRef As DataGridViewTextBoxColumn
    Friend WithEvents colPassenger As DataGridViewTextBoxColumn
    Friend WithEvents colPhone As DataGridViewTextBoxColumn
    Friend WithEvents colSeats As DataGridViewTextBoxColumn
    Friend WithEvents colFrom As DataGridViewTextBoxColumn
    Friend WithEvents colTo As DataGridViewTextBoxColumn
    Friend WithEvents colFare As DataGridViewTextBoxColumn
    Friend WithEvents colPayment As DataGridViewTextBoxColumn
    Friend WithEvents lblSummary As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents ToolTip1 As ToolTip

End Class
