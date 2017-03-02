Imports System.Data.SqlClient

Public Class frmStock_Out

    Private tp As New TabPage("Stock_Out")
    Private pForm As frmMaster

    Private Sub frmStock_Out_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        frmMaster.ToggleControls(True)
        LoadSpreadStockOut()
        LoadDepartment()
        LoadCategory()
        LoadReceiver()
    End Sub

    Private Sub LoadDepartment()
        cmbSODepartment.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Dept_Name from m_Dept"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cmbSODepartment.Items.Add(rs("v_Dept_Name").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub LoadReceiver()
        cmbReceiver.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Receiver_Name from m_Receiver"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cmbReceiver.Items.Add(rs("v_Receiver_Name").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub LoadCategory()
        cmbCategory.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Category_Name from m_Category"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cmbCategory.Items.Add(rs("v_Category_Name").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub cmbSODepartment_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSODepartment.SelectedIndexChanged
        sql = "Select * from m_Dept where v_Dept_Name='" & cmbSODepartment.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtDepartmentCode.Text = rs("pn_Dept_Code").Value
        End If
        rs.Close()

    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCategory.SelectedIndexChanged
        sql = "Select * from m_Category where v_Category_Name='" & cmbCategory.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtCategoryNo.Text = rs("pn_Category_No").Value
        End If
        rs.Close()
    End Sub

    Private Sub cmbReceiver_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReceiver.SelectedIndexChanged
        sql = "Select * from m_Receiver where v_Receiver_Name='" & cmbReceiver.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtReceiverId.Text = rs("pn_Receiver_Id").Value
        End If
        rs.Close()
    End Sub

    Private Sub sprStockOut_Advance(ByVal sender As System.Object, ByVal e As AxFPSpread._DSpreadEvents_AdvanceEvent) Handles sprStockOut.Advance

    End Sub

    Private Sub LoadSpreadStockOut()
        sprStockOut.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from m_Item"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                sprStockOut.MaxRows = sprStockOut.MaxRows + 1
                sprStockOut.Row = sprStockOut.MaxRows
                sprStockOut.Col = 1
                sprStockOut.TypeButtonText = "Edit"
                sprStockOut.Col = 1
                sprStockOut.Text = rs("pn_Item_No").Value
                sprStockOut.Col = 2
                sprStockOut.Text = rs("v_Item_Name").Value
                sprStockOut.Col = 3
                sprStockOut.Text = rs("v_Item_Measurement").Value
                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Private Sub frmStock_Out_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIssue.Click

    End Sub
End Class
