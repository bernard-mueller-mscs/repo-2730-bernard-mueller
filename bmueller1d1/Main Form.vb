' Name: Bakery Project
' Purpose: Calculates the total number of items sold and total sales
' Programmer: Bernie Mueller on 8/28/2017

Option Strict On

Public Class frmMain
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		' prepare screen for the next sale
		txtDonuts.Text = String.Empty
		txtMuffins.Text = String.Empty
		lblTotalItems.Text = String.Empty
		lblTotalSales.Text = String.Empty
		txtDonuts.Focus()
		' send the focus to the Doughnuts box
	End Sub

	Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

	End Sub

	Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
		' calculate number of items sold and total sales
		lblTotalItems.Text = Format(Val(txtDonuts.Text) + Val(txtMuffins.Text), "0")
		lblTotalSales.Text = Format(Val(lblTotalItems.Text) * 0.5, "currency")
		'lblTotalSales.Text = Format(lblTotalItems.Text, "currency") 
	End Sub

	Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

	End Sub

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class
