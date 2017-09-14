'Name: Cranston Berries Project
'Purpose: Calculates projected sales
'Programmer: Bernie Mueller on 9/14/2017

Option Strict On

Public Class frmMain
	Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
		'Calculates Projected Sales
		lblProjStaw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
		lblProjBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
		lblProjRas.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRas.Text), "currency")
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		'prepares screen for next projected sales
		txtStraw.Text = String.Empty
		txtBlue.Text = String.Empty
		txtRas.Text = String.Empty
		lblProjStaw.Text = String.Empty
		lblProjBlue.Text = String.Empty
		lblProjRas.Text = String.Empty
		txtProjIncrease.Focus()
		'sends focus back to Projected Increase
	End Sub

	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub


End Class
