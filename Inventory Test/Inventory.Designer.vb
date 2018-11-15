<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHeadline = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAmountToOrder = New System.Windows.Forms.Label()
        Me.lblNoneNeeded = New System.Windows.Forms.Label()
        Me.lblRushOrder = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAverageSoldPerMonth = New System.Windows.Forms.TextBox()
        Me.txtCurrentOnhand = New System.Windows.Forms.TextBox()
        Me.txtAllocated = New System.Windows.Forms.TextBox()
        Me.txtAvailable = New System.Windows.Forms.TextBox()
        Me.txtSoldPerDay = New System.Windows.Forms.TextBox()
        Me.txtDaysLeftOfOnhand = New System.Windows.Forms.TextBox()
        Me.txtAmountToOrder = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(465, 136)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(81, 25)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseCompatibleTextRendering = True
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(465, 182)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 25)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseCompatibleTextRendering = True
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSalmon
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(465, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 25)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseCompatibleTextRendering = True
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblHeadline
        '
        Me.lblHeadline.AutoSize = True
        Me.lblHeadline.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadline.Location = New System.Drawing.Point(229, 74)
        Me.lblHeadline.Name = "lblHeadline"
        Me.lblHeadline.Size = New System.Drawing.Size(275, 24)
        Me.lblHeadline.TabIndex = 3
        Me.lblHeadline.Text = "Inventory Needed Calculator"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Average Sold per Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Current Onhand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Allocated"
        '
        'lblAmountToOrder
        '
        Me.lblAmountToOrder.AutoSize = True
        Me.lblAmountToOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountToOrder.Location = New System.Drawing.Point(74, 323)
        Me.lblAmountToOrder.Name = "lblAmountToOrder"
        Me.lblAmountToOrder.Size = New System.Drawing.Size(96, 15)
        Me.lblAmountToOrder.TabIndex = 7
        Me.lblAmountToOrder.Text = "Amount to Order"
        Me.lblAmountToOrder.Visible = False
        '
        'lblNoneNeeded
        '
        Me.lblNoneNeeded.AutoSize = True
        Me.lblNoneNeeded.BackColor = System.Drawing.Color.PaleGreen
        Me.lblNoneNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoneNeeded.Location = New System.Drawing.Point(74, 368)
        Me.lblNoneNeeded.Name = "lblNoneNeeded"
        Me.lblNoneNeeded.Size = New System.Drawing.Size(144, 15)
        Me.lblNoneNeeded.TabIndex = 8
        Me.lblNoneNeeded.Text = "None needed at this time"
        Me.lblNoneNeeded.Visible = False
        '
        'lblRushOrder
        '
        Me.lblRushOrder.AutoSize = True
        Me.lblRushOrder.BackColor = System.Drawing.SystemColors.Control
        Me.lblRushOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRushOrder.ForeColor = System.Drawing.Color.Red
        Me.lblRushOrder.Location = New System.Drawing.Point(300, 323)
        Me.lblRushOrder.Name = "lblRushOrder"
        Me.lblRushOrder.Size = New System.Drawing.Size(103, 15)
        Me.lblRushOrder.TabIndex = 9
        Me.lblRushOrder.Text = "RUSH ORDER!"
        Me.lblRushOrder.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(316, 411)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Available"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(316, 453)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 15)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Sold per Day"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(316, 495)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Days Left of Onhand"
        '
        'txtAverageSoldPerMonth
        '
        Me.txtAverageSoldPerMonth.Location = New System.Drawing.Point(233, 136)
        Me.txtAverageSoldPerMonth.Name = "txtAverageSoldPerMonth"
        Me.txtAverageSoldPerMonth.Size = New System.Drawing.Size(47, 20)
        Me.txtAverageSoldPerMonth.TabIndex = 0
        '
        'txtCurrentOnhand
        '
        Me.txtCurrentOnhand.Location = New System.Drawing.Point(233, 187)
        Me.txtCurrentOnhand.Name = "txtCurrentOnhand"
        Me.txtCurrentOnhand.Size = New System.Drawing.Size(47, 20)
        Me.txtCurrentOnhand.TabIndex = 1
        '
        'txtAllocated
        '
        Me.txtAllocated.Location = New System.Drawing.Point(233, 233)
        Me.txtAllocated.Name = "txtAllocated"
        Me.txtAllocated.Size = New System.Drawing.Size(47, 20)
        Me.txtAllocated.TabIndex = 2
        '
        'txtAvailable
        '
        Me.txtAvailable.Location = New System.Drawing.Point(480, 406)
        Me.txtAvailable.Name = "txtAvailable"
        Me.txtAvailable.Size = New System.Drawing.Size(47, 20)
        Me.txtAvailable.TabIndex = 16
        Me.txtAvailable.TabStop = False
        '
        'txtSoldPerDay
        '
        Me.txtSoldPerDay.Location = New System.Drawing.Point(480, 448)
        Me.txtSoldPerDay.Name = "txtSoldPerDay"
        Me.txtSoldPerDay.Size = New System.Drawing.Size(47, 20)
        Me.txtSoldPerDay.TabIndex = 17
        Me.txtSoldPerDay.TabStop = False
        '
        'txtDaysLeftOfOnhand
        '
        Me.txtDaysLeftOfOnhand.Location = New System.Drawing.Point(480, 490)
        Me.txtDaysLeftOfOnhand.Name = "txtDaysLeftOfOnhand"
        Me.txtDaysLeftOfOnhand.Size = New System.Drawing.Size(47, 20)
        Me.txtDaysLeftOfOnhand.TabIndex = 18
        Me.txtDaysLeftOfOnhand.TabStop = False
        '
        'txtAmountToOrder
        '
        Me.txtAmountToOrder.Location = New System.Drawing.Point(233, 318)
        Me.txtAmountToOrder.Name = "txtAmountToOrder"
        Me.txtAmountToOrder.Size = New System.Drawing.Size(47, 20)
        Me.txtAmountToOrder.TabIndex = 19
        Me.txtAmountToOrder.TabStop = False
        Me.txtAmountToOrder.Visible = False
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(804, 656)
        Me.Controls.Add(Me.txtAmountToOrder)
        Me.Controls.Add(Me.txtDaysLeftOfOnhand)
        Me.Controls.Add(Me.txtSoldPerDay)
        Me.Controls.Add(Me.txtAvailable)
        Me.Controls.Add(Me.txtAllocated)
        Me.Controls.Add(Me.txtCurrentOnhand)
        Me.Controls.Add(Me.txtAverageSoldPerMonth)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblRushOrder)
        Me.Controls.Add(Me.lblNoneNeeded)
        Me.Controls.Add(Me.lblAmountToOrder)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeadline)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Inventory"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblHeadline As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAmountToOrder As Label
    Friend WithEvents lblNoneNeeded As Label
    Friend WithEvents lblRushOrder As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAverageSoldPerMonth As TextBox
    Friend WithEvents txtCurrentOnhand As TextBox
    Friend WithEvents txtAllocated As TextBox
    Friend WithEvents txtAvailable As TextBox
    Friend WithEvents txtSoldPerDay As TextBox
    Friend WithEvents txtDaysLeftOfOnhand As TextBox
    Friend WithEvents txtAmountToOrder As TextBox
End Class
