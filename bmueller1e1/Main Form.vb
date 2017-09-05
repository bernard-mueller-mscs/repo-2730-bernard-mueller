' Name: Richardson Country Property Tax Project
' Purpose: Calculates property tax
' Programmer: Bernie Mueller on 9/4/2017

Public Class frmMain
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub txtAssessed_TextChanged(sender As Object, e As EventArgs) Handles txtAssessed.TextChanged

	End Sub

	Private Sub LblTax_Click(sender As Object, e As EventArgs) Handles lblTax.Click

	End Sub

	Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
		' calculate annual property tax
		lblTax.Text = Val(txtAssessed.Text) * 0.015
		lblTax.Text = Format(lblTax.Text, "currency")
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		' prepares screen for next annual property tax
		txtAssessed.Text = String.Empty
		lblTax.Text = String.Empty
		txtAssessed.Focus()
		' sends focus back to assessed value
	End Sub
End Class
