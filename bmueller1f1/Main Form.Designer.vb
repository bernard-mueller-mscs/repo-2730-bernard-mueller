<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Me.txt = New System.Windows.Forms.Label()
		Me.txtProjIncrease = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtStraw = New System.Windows.Forms.TextBox()
		Me.txtBlue = New System.Windows.Forms.TextBox()
		Me.txtRas = New System.Windows.Forms.TextBox()
		Me.lblProjStaw = New System.Windows.Forms.Label()
		Me.lblProjBlue = New System.Windows.Forms.Label()
		Me.lblProjRas = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.btnCalc = New System.Windows.Forms.Button()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'txt
		'
		Me.txt.Font = New System.Drawing.Font("Segoe UI", 12.0!)
		Me.txt.Location = New System.Drawing.Point(206, 9)
		Me.txt.Name = "txt"
		Me.txt.Size = New System.Drawing.Size(210, 67)
		Me.txt.TabIndex = 10
		Me.txt.Text = "Projected increase % (in decimal form):"
		'
		'txtProjIncrease
		'
		Me.txtProjIncrease.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtProjIncrease.Location = New System.Drawing.Point(422, 21)
		Me.txtProjIncrease.Multiline = True
		Me.txtProjIncrease.Name = "txtProjIncrease"
		Me.txtProjIncrease.Size = New System.Drawing.Size(84, 33)
		Me.txtProjIncrease.TabIndex = 0
		Me.txtProjIncrease.Text = "0.05"
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(34, 114)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(104, 22)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "&Strawberries:"
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(34, 175)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(90, 25)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "&Blueberries:"
		'
		'Label3
		'
		Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(34, 232)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(90, 24)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "&Raspberries:"
		'
		'txtStraw
		'
		Me.txtStraw.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStraw.Location = New System.Drawing.Point(144, 114)
		Me.txtStraw.Multiline = True
		Me.txtStraw.Name = "txtStraw"
		Me.txtStraw.Size = New System.Drawing.Size(119, 34)
		Me.txtStraw.TabIndex = 2
		'
		'txtBlue
		'
		Me.txtBlue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtBlue.Location = New System.Drawing.Point(144, 172)
		Me.txtBlue.Multiline = True
		Me.txtBlue.Name = "txtBlue"
		Me.txtBlue.Size = New System.Drawing.Size(119, 35)
		Me.txtBlue.TabIndex = 4
		'
		'txtRas
		'
		Me.txtRas.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtRas.Location = New System.Drawing.Point(144, 229)
		Me.txtRas.Multiline = True
		Me.txtRas.Name = "txtRas"
		Me.txtRas.Size = New System.Drawing.Size(119, 35)
		Me.txtRas.TabIndex = 6
		'
		'lblProjStaw
		'
		Me.lblProjStaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblProjStaw.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProjStaw.Location = New System.Drawing.Point(365, 113)
		Me.lblProjStaw.Name = "lblProjStaw"
		Me.lblProjStaw.Size = New System.Drawing.Size(119, 35)
		Me.lblProjStaw.TabIndex = 13
		'
		'lblProjBlue
		'
		Me.lblProjBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblProjBlue.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProjBlue.Location = New System.Drawing.Point(365, 174)
		Me.lblProjBlue.Name = "lblProjBlue"
		Me.lblProjBlue.Size = New System.Drawing.Size(119, 35)
		Me.lblProjBlue.TabIndex = 14
		'
		'lblProjRas
		'
		Me.lblProjRas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblProjRas.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblProjRas.Location = New System.Drawing.Point(365, 231)
		Me.lblProjRas.Name = "lblProjRas"
		Me.lblProjRas.Size = New System.Drawing.Size(119, 35)
		Me.lblProjRas.TabIndex = 15
		'
		'Label7
		'
		Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(144, 76)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(105, 25)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "Current Sales"
		'
		'Label8
		'
		Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(367, 76)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(117, 25)
		Me.Label8.TabIndex = 12
		Me.Label8.Text = "Projected Sales"
		'
		'btnCalc
		'
		Me.btnCalc.Location = New System.Drawing.Point(22, 294)
		Me.btnCalc.Name = "btnCalc"
		Me.btnCalc.Size = New System.Drawing.Size(102, 38)
		Me.btnCalc.TabIndex = 7
		Me.btnCalc.Text = "&Calculate"
		Me.btnCalc.UseVisualStyleBackColor = True
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(148, 294)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(102, 38)
		Me.btnPrint.TabIndex = 16
		Me.btnPrint.Text = "&Print"
		Me.btnPrint.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(277, 294)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(102, 38)
		Me.btnClear.TabIndex = 8
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(404, 294)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(102, 38)
		Me.btnExit.TabIndex = 9
		Me.btnExit.Text = "E&xit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.bmueller1f1.My.Resources.Resources.download
		Me.PictureBox1.Location = New System.Drawing.Point(11, 9)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(127, 92)
		Me.PictureBox1.TabIndex = 17
		Me.PictureBox1.TabStop = False
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(547, 364)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnPrint)
		Me.Controls.Add(Me.btnCalc)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.lblProjRas)
		Me.Controls.Add(Me.lblProjBlue)
		Me.Controls.Add(Me.lblProjStaw)
		Me.Controls.Add(Me.txtRas)
		Me.Controls.Add(Me.txtBlue)
		Me.Controls.Add(Me.txtStraw)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtProjIncrease)
		Me.Controls.Add(Me.txt)
		Me.Name = "frmMain"
		Me.Text = "Cranston Berries"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txt As Label
	Friend WithEvents txtProjIncrease As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents txtStraw As TextBox
	Friend WithEvents txtBlue As TextBox
	Friend WithEvents txtRas As TextBox
	Friend WithEvents lblProjStaw As Label
	Friend WithEvents lblProjBlue As Label
	Friend WithEvents lblProjRas As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents btnCalc As Button
	Friend WithEvents btnPrint As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents PictureBox1 As PictureBox
End Class
