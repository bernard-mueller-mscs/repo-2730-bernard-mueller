﻿'Name: Average Project	
'Purpose:Displayes the average of 3 test scores
'Programmer: Bernie Mueller 9/19/2017

Option Strict On

Public Class frmName
	Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
		'calculates average test score
		lblAverage.Text = Format((Val(txtTest1.Text) + Val(txtTest2.Text) + Val(txtTest3.Text)) / 3, "00")
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		'prepares screen for next average
		txtTest1.Text = String.Empty
		txtTest2.Text = String.Empty
		txtTest3.Text = String.Empty
		lblAverage.Text = String.Empty
		txtTest1.Focus()
		'Sends focus back to Test score 1
	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub
End Class
