Public Class frmStockIn

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxUnit.SelectedIndexChanged
        sql = "Select * from m_Item where v_Item_Measurement='" & cbxUnit.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        'If Not rs.EOF Then
        '    txtdepCode.Text = rs("pn_Dept_Code").Value
        'End If
        rs.Close()
    End Sub

    Private Sub pnlDepCatIt_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlDepCatIt.Paint

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReceiver.TextChanged
        sql = "Select * from m_Receiver where v_Receiver_Name='" & txtReceiver.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtReceiver.Text = rs("v_Receiver_Name").Value
        End If
        rs.Close()
    End Sub

    Private Sub lblDeliverer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDeliverer.Click

    End Sub

    Private Sub lblQuantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblQuantity.Click

    End Sub

    Private Sub frmStockIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDepartment()
        LoadCategory()
        LoadItems()
        LoadUnit()
        LoadSupplier()
    End Sub

    Private Sub cbxDep_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxDep.SelectedIndexChanged
        sql = "Select * from m_Dept where v_Dept_Name='" & cbxDep.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtdepCode.Text = rs("pn_Dept_Code").Value
        End If
        rs.Close()

    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxCategory.SelectedIndexChanged
        sql = "Select * from m_Category where v_Category_Name='" & cbxCategory.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        'If Not rs.EOF Then
        '    cbxCategory.Text = rs("v_Category_Name").Value
        'End If
        rs.Close()

    End Sub

    Private Sub cbxItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxItem.SelectedIndexChanged
        sql = "Select * from m_Item where v_Item_Name='" & cbxItem.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtItem.Text = rs("pn_Item_No").Value
        End If
        rs.Close()
    End Sub

    Private Sub cbxSupplier_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxSupplier.SelectedIndexChanged
        sql = "Select * from m_Supplier where v_Supplier_Name='" & cbxSupplier.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            cbxSupplier.Text = rs("v_Supplier_Name").Value
        End If
        rs.Close()
    End Sub

    Private Sub txtDeliverer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeliverer.TextChanged
        sql = "Select * from t_Stock_InOut where v_Deliverer_Name='" & txtDeliverer.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            txtDeliverer.Text = rs("v_Deliverer_Name").Value
        End If
        rs.Close()
    End Sub
    Private Sub LoadDepartment()
        cbxDep.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Dept_Name from m_Dept"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxDep.Items.Add(rs("v_Dept_Name").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub LoadUnit()
        cbxUnit.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Item_Measurement from m_Item"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxUnit.Items.Add(rs("v_Item_Measurement").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub
    Private Sub LoadSupplier()
        cbxSupplier.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Supplier_Name from m_Supplier"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxSupplier.Items.Add(rs("v_Supplier_Name").Value)
            'txtSupplierRef.Text = rs("pn_Supplier_Ref_No").Value
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub
    Private Sub LoadItems()
        cbxItem.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Item_Name from m_Item"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxItem.Items.Add(rs("v_Item_Name").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub
    Private Sub LoadCategory()
        cbxCategory.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select v_Category_Name from m_Category"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxCategory.Items.Add(rs("v_Category_Name").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub ClearStockIn()
        cbxDep.Text = ""
        cbxCategory.Text = ""
        cbxItem.Text = ""
        txtQuantity.Text = ""
        txtReceiver.Text = ""
        txtDeliverer.Text = ""
        txtRemark.Text = ""
        cbxSupplier.Text = ""
    End Sub

    Private Sub btnReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceive.Click
        'LoadDepartment()
        'LoadCategory()
        Dim rsSaveStockIn As New ADODB.Recordset
        sql = "select * from m_Item where v_Item_Name='" & cbxItem.Text & "'"
        sql = "select * from t_Stock_InOut where fn_Item_No='" & txtItem.Text & "'"
        sql = "select * from m_Dept where v_Dept_Name='" & cbxDep.Text & "'"
        rsSaveStockIn.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsSaveStockIn.EOF Then
            rsSaveStockIn.AddNew()
            rsSaveStockIn("fn_Item_No").Value = txtItem.Text
            rsSaveStockIn("v_Dept_Name").Value = cbxDep.Text
            rsSaveStockIn("v_Category_Name").Value = cbxCategory.Text
            rsSaveStockIn("n_Received_Quantity").Value = txtQuantity.Text
            rsSaveStockIn("v_Deliverer_Name").Value = txtDeliverer.Text
            rsSaveStockIn("v_Receiver_Name").Value = txtReceiver.Text
            rsSaveStockIn("d_Received_Date").Value = DateStockIn.Text
            rsSaveStockIn("v_Recieved_Remarks").Value = txtRemark.Text
            rsSaveStockIn("fn_Receiver_Idt").Value = txtReceiverID.Text
            rsSaveStockIn("fn_Supplier_RefNo").Value = txtSupplierRef.Text
            rsSaveStockIn("v_Item_Measurement").Value = cbxUnit.Text
            rsSaveStockIn.Update()

        End If
        ClearStockIn()
        MsgBox("Goods have been received")

    End Sub
End Class