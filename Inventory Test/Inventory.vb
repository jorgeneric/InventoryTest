Public Class Inventory
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Variable for calculations

        Dim LeadTime As Integer = 7
        Dim DaysInAMonth As Integer = 30
        Dim AverageSoldPerMonth As Integer
        Dim CurrentOnhand As Integer
        Dim Allocated As Integer
        Dim Available As Integer
        Dim SoldPerDay As Integer
        Dim DaysLeftofOnhand As Integer
        Dim AmountToOrder As Integer

        ' Below is the INPUT

        Integer.TryParse(txtAverageSoldPerMonth.Text, AverageSoldPerMonth)
        Integer.TryParse(txtCurrentOnhand.Text, CurrentOnhand)
        Integer.TryParse(txtAllocated.Text, Allocated)

        ' Calculation

        Available = CurrentOnhand - Allocated
        SoldPerDay = AverageSoldPerMonth / DaysInAMonth
        DaysLeftofOnhand = Available / SoldPerDay

        If SoldPerDay < 1 Then SoldPerDay = 1


        If DaysLeftofOnhand <= 5 = True Then
            AmountToOrder = (2 * LeadTime - DaysLeftofOnhand) * SoldPerDay
            lblAmountToOrder.Visible = True
            txtAmountToOrder.Visible = True
        End If


        If DaysLeftofOnhand > 5 = True Then
            AmountToOrder = 0
            lblAmountToOrder.Visible = True
            txtAmountToOrder.Visible = False
            lblNoneNeeded.Visible = True
        End If

        If AmountToOrder > 0 = True And AverageSoldPerMonth >= 200 Then
            lblAmountToOrder.Visible = True
            lblRushOrder.Visible = True

        End If


        ' OUTPUT

        txtAvailable.Text = Convert.ToString(Available)
        txtSoldPerDay.Text = Convert.ToString(SoldPerDay)
        txtAmountToOrder.Text = Convert.ToString(AmountToOrder)
        txtDaysLeftOfOnhand.Text = Convert.ToString(DaysLeftofOnhand)


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtAverageSoldPerMonth.Text = String.Empty
        txtCurrentOnhand.Text = String.Empty
        txtAllocated.Text = String.Empty
        txtAmountToOrder.Text = String.Empty
        txtAvailable.Text = String.Empty
        txtSoldPerDay.Text = String.Empty
        txtDaysLeftOfOnhand.Text = String.Empty
        lblAmountToOrder.Visible = False
        lblRushOrder.Visible = False
        lblNoneNeeded.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtAverageSoldPerMonth_TextChanged(sender As Object, e As EventArgs) Handles txtAverageSoldPerMonth.TextChanged

    End Sub
End Class
