﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
		Me.lblName = New System.Windows.Forms.Label()
		Me.lblMsg = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.picStorks = New System.Windows.Forms.PictureBox()
		Me.picIguanas = New System.Windows.Forms.PictureBox()
		Me.tmrExit4 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.picStorks, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picIguanas, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblName
		'
		Me.lblName.AutoSize = True
		Me.lblName.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblName.Location = New System.Drawing.Point(187, 72)
		Me.lblName.Name = "lblName"
		Me.lblName.Size = New System.Drawing.Size(101, 20)
		Me.lblName.TabIndex = 0
		Me.lblName.Text = "Crighton Zoo"
		'
		'lblMsg
		'
		Me.lblMsg.AutoSize = True
		Me.lblMsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.lblMsg.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblMsg.ForeColor = System.Drawing.Color.Red
		Me.lblMsg.Location = New System.Drawing.Point(187, 115)
		Me.lblMsg.Name = "lblMsg"
		Me.lblMsg.Size = New System.Drawing.Size(176, 20)
		Me.lblMsg.TabIndex = 1
		Me.lblMsg.Text = "Come visit our residents!"
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.Label1.Location = New System.Drawing.Point(10, 10)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(365, 274)
		Me.Label1.TabIndex = 2
		'
		'picStorks
		'
		Me.picStorks.Image = Global.bmueller1b1.My.Resources.Resources.Storks
		Me.picStorks.Location = New System.Drawing.Point(196, 137)
		Me.picStorks.Name = "picStorks"
		Me.picStorks.Size = New System.Drawing.Size(167, 144)
		Me.picStorks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picStorks.TabIndex = 4
		Me.picStorks.TabStop = False
		'
		'picIguanas
		'
		Me.picIguanas.Image = Global.bmueller1b1.My.Resources.Resources.Iguanas
		Me.picIguanas.Location = New System.Drawing.Point(14, 12)
		Me.picIguanas.Name = "picIguanas"
		Me.picIguanas.Size = New System.Drawing.Size(160, 144)
		Me.picIguanas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.picIguanas.TabIndex = 3
		Me.picIguanas.TabStop = False
		'
		'tmrExit4
		'
		Me.tmrExit4.Enabled = True
		Me.tmrExit4.Interval = 4000
		'
		'frmSplash
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(387, 293)
		Me.ControlBox = False
		Me.Controls.Add(Me.picStorks)
		Me.Controls.Add(Me.picIguanas)
		Me.Controls.Add(Me.lblMsg)
		Me.Controls.Add(Me.lblName)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
		Me.Name = "frmSplash"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		CType(Me.picStorks, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picIguanas, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblName As Label
	Friend WithEvents lblMsg As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents picIguanas As PictureBox
	Friend WithEvents picStorks As PictureBox
	Friend WithEvents tmrExit4 As Timer
End Class
