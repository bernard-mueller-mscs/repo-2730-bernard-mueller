<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmName
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
		Me.txtTest1 = New System.Windows.Forms.TextBox()
		Me.txtTest2 = New System.Windows.Forms.TextBox()
		Me.txtTest3 = New System.Windows.Forms.TextBox()
		Me.lblAverage = New System.Windows.Forms.Label()
		Me.btnCalculate = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'txtTest1
		'
		Me.txtTest1.Location = New System.Drawing.Point(146, 66)
		Me.txtTest1.Multiline = True
		Me.txtTest1.Name = "txtTest1"
		Me.txtTest1.Size = New System.Drawing.Size(92, 41)
		Me.txtTest1.TabIndex = 1
		'
		'txtTest2
		'
		Me.txtTest2.Location = New System.Drawing.Point(146, 145)
		Me.txtTest2.Multiline = True
		Me.txtTest2.Name = "txtTest2"
		Me.txtTest2.Size = New System.Drawing.Size(92, 41)
		Me.txtTest2.TabIndex = 2
		'
		'txtTest3
		'
		Me.txtTest3.Location = New System.Drawing.Point(146, 218)
		Me.txtTest3.Multiline = True
		Me.txtTest3.Name = "txtTest3"
		Me.txtTest3.Size = New System.Drawing.Size(92, 41)
		Me.txtTest3.TabIndex = 3
		'
		'lblAverage
		'
		Me.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblAverage.Location = New System.Drawing.Point(188, 273)
		Me.lblAverage.Name = "lblAverage"
		Me.lblAverage.Size = New System.Drawing.Size(106, 33)
		Me.lblAverage.TabIndex = 0
		'
		'btnCalculate
		'
		Me.btnCalculate.Location = New System.Drawing.Point(297, 66)
		Me.btnCalculate.Name = "btnCalculate"
		Me.btnCalculate.Size = New System.Drawing.Size(113, 41)
		Me.btnCalculate.TabIndex = 4
		Me.btnCalculate.Text = "&Calculate"
		Me.btnCalculate.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(297, 145)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(113, 41)
		Me.btnClear.TabIndex = 5
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(297, 218)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(113, 41)
		Me.btnExit.TabIndex = 6
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(23, 74)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(113, 25)
		Me.Label2.TabIndex = 7
		Me.Label2.Text = "Test score &1:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(23, 153)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(113, 25)
		Me.Label3.TabIndex = 8
		Me.Label3.Text = "Test score &2:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(23, 226)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(113, 25)
		Me.Label4.TabIndex = 9
		Me.Label4.Text = "Test score &3:"
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(12, 274)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(170, 25)
		Me.Label5.TabIndex = 10
		Me.Label5.Text = "Average test score:"
		'
		'frmName
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(440, 325)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCalculate)
		Me.Controls.Add(Me.lblAverage)
		Me.Controls.Add(Me.txtTest3)
		Me.Controls.Add(Me.txtTest2)
		Me.Controls.Add(Me.txtTest1)
		Me.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "frmName"
		Me.Text = "bmueller1g1:Average Calculator"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtTest1 As TextBox
	Friend WithEvents txtTest2 As TextBox
	Friend WithEvents txtTest3 As TextBox
	Friend WithEvents lblAverage As Label
	Friend WithEvents btnCalculate As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
End Class
