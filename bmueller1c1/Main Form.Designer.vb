﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btnExit
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
		Me.components = New System.ComponentModel.Container()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.25!, System.Drawing.FontStyle.Bold)
		Me.Label1.Location = New System.Drawing.Point(81, 25)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(180, 30)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Summer Carnival"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
		Me.Label2.ForeColor = System.Drawing.Color.Red
		Me.Label2.Location = New System.Drawing.Point(16, 219)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(311, 28)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Come join the fun at Valley Park!"
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 3000
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.bmueller1c1.My.Resources.Resources.Carnival
		Me.PictureBox1.Location = New System.Drawing.Point(81, 67)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(181, 136)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'Timer2
		'
		Me.Timer2.Enabled = True
		Me.Timer2.Interval = 6000
		'
		'Timer3
		'
		Me.Timer3.Enabled = True
		Me.Timer3.Interval = 9000
		'
		'btnExit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(352, 288)
		Me.ControlBox = False
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "btnExit"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Timer1 As Timer
	Friend WithEvents Timer2 As Timer
	Friend WithEvents Timer3 As Timer
End Class
