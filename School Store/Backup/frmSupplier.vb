Imports System.Data.SqlClient

Public Class frmSupplier
    Implements StoreInterface

    Dim modSupplier As String = "QUERY"
    Dim autoNo2 As Integer
    Private tp As New TabPage("Supplier")
    Private pForm As frmMaster

    Private Sub frmSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        frmMaster.ToggleControls(True)
        LoadSpreadSupplier()
    End Sub

    Private Sub GenerateSupplierRefNo()
        Dim rs As New ADODB.Recordset
        sql = "select MAX(pn_Supplier_Ref_No) as autoNo  from m_Supplier"

        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If IsDBNull(rs("autoNo").Value) Then
            'autoNo = rs("autoNo").Value
            autoNo2 = 100
        Else
            autoNo2 = rs("autoNo").Value + 1
        End If
        rs.Close()
    End Sub

    Private Sub ClearSupplier()
        txtContactPerson.Text = ""
        txtPhoneNo1.Text = ""
        txtPhoneNo2.Text = ""
        txtSupplierName.Text = ""
        txtEmail.Text = ""
        txtMobile.Text = ""
    End Sub

    Public Sub FormCancel() Implements StoreInterface.FormCancel
        ClearSupplier()
        frmMaster.ToggleControls(True)
    End Sub

    Public Sub FormEdit() Implements StoreInterface.FormEdit
        mode = "EDIT"
        frmMaster.ToggleControls(False)
    End Sub

    Public Sub FormNew() Implements StoreInterface.FormNew
        mode = "NEW"
        ClearSupplier()
        frmMaster.ToggleControls(False)
    End Sub

    Public Sub FormSave() Implements StoreInterface.FormSave
        SaveSupplier()
    End Sub

    Private Sub SaveSupplier()
        GenerateSupplierRefNo()
        conn.BeginTrans()
        
        If mode = "NEW" Then
            sql = "select * from m_Supplier where v_Supplier_Name='" & txtSupplierName.Text & "'"

            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)

            If Not rs.EOF Then
                conn.RollbackTrans()
                Me.Cursor = Cursors.Arrow
                MsgBox("Supplier name exist,please enter different name", MsgBoxStyle.Information, "Supplier")
                rs.Close()
                Exit Sub
            Else
                rs.AddNew()
                rs("pn_Supplier_Ref_No").Value = autoNo2
            End If
        ElseIf mode = "EDIT" Then
            sprSupplier.Row = sprSupplier.ActiveRow
            sprSupplier.Col = 2
            sql = "select * from m_Supplier where pn_Supplier_Ref_No='" & sprSupplier.Text & "'"
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            If rs.EOF Then
                conn.RollbackTrans()
                Me.Cursor = Cursors.Arrow
                MsgBox("Supplier name does not exist", MsgBoxStyle.Information, "Supplier")
                rs.Close()
                Exit Sub
            End If
        End If
        conn.BeginTrans()
        Me.Cursor = Cursors.WaitCursor
        Try
            rs("v_Supplier_Name").Value = txtSupplierName.Text
            rs("v_Phone_No1").Value = txtPhoneNo1.Text
            rs("v_Phone_No2").Value = txtPhoneNo2.Text
            rs("v_Email").Value = txtEmail.Text
            rs("v_Contact_Person").Value = txtContactPerson.Text
            rs("v_Mobile").Value = txtMobile.Text
            rs.Update()

            conn.CommitTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox("Saved successfully", MsgBoxStyle.Information, "Supplier")
            ClearSupplier()
            rs.Close()
            LoadSpreadSupplier()
            frmMaster.ToggleControls(True)

            modSupplier = "QUERY"

        Catch ex As Exception
            conn.RollbackTrans()
            Me.Cursor = Cursors.Arrow
            MsgBox(ex.Message, MsgBoxStyle.Information, "User")
        End Try

    End Sub

    Private Sub frmSupplier_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim result As DialogResult
        If modSupplier = "UPDATE" Then
            result = MessageBox.Show("Do you want to close the form without saving?", "Supplier", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = Windows.Forms.DialogResult.OK Then
                modSupplier = "QUERY"
                frmMaster.ToggleControls(True)
            Else
                e.Cancel = True
                Exit Sub
            End If
        End If
        pForm.RemoveTabPage(tp)
    End Sub

    Private Sub sprSupplier_ClickEvent(ByVal sender As System.Object, ByVal e As AxFPSpread._DSpreadEvents_ClickEvent) Handles sprSupplier.ClickEvent
        sprSupplier.Row = sprSupplier.ActiveRow
        sprSupplier.Col = 1
        sql = "SELECT * FROM m_Supplier where v_Supplier_Name= '" & sprSupplier.Text & "'"

        Try
            rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        If Not rs.EOF Then
            txtContactPerson.Text = rs("v_Contact_Person").Value
            txtSupplierName.Text = rs("v_Supplier_Name").Value
            txtEmail.Text = rs("v_Email").Value
            txtPhoneNo1.Text = rs("v_Phone_No1").Value
            txtMobile.Text = rs("v_Mobile").Value
        Else
            MsgBox("No Suplier. Add new")
        End If

        rs.Close()

    End Sub

    Private Sub LoadSpreadSupplier()
        sprSupplier.MaxRows = 0
        rs = New ADODB.Recordset
        sql = "Select * from m_Supplier"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            Do Until rs.EOF
                sprSupplier.MaxRows = sprSupplier.MaxRows + 1
                sprSupplier.Row = sprSupplier.MaxRows
                sprSupplier.Col = 1
                sprSupplier.TypeButtonText = "Edit"
                sprSupplier.Col = 1
                sprSupplier.Text = rs("v_Supplier_Name").Value
                sprSupplier.Col = 2
                sprSupplier.Text = rs("v_Email").Value
                sprSupplier.Col = 3
                sprSupplier.Text = rs("v_Contact_Person").Value
                sprSupplier.Col = 4
                sprSupplier.Text = rs("pn_Supplier_Ref_No").Value
                sprSupplier.Col = 5
                sprSupplier.Text = rs("v_Mobile").Value

                rs.MoveNext()
            Loop

        End If
        rs.Close()
    End Sub

    Private Sub txtContactPerson_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContactPerson.TextChanged

    End Sub

    Private Sub txtSupplierName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSupplierName.TextChanged

    End Sub

    Public Sub FormSubmit() Implements StoreInterface.FormSubmit

    End Sub

   
    
    Private Sub txtPhoneNo1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNo1.KeyPress
        Dim phoneNo As String = "01234567890+-"
        If phoneNo.IndexOf(e.KeyChar) = -1 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar.ToString().Equals(".") Then
            If Me.Text.Contains(".") Then
                e.Handled = True
            Else : e.Handled = False
            End If
        End If
    End Sub

    Private Sub txtPhoneNo2_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhoneNo2.KeyPress
        Dim phoneNo As String = "01234567890+-"
        If phoneNo.IndexOf(e.KeyChar) = -1 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar.ToString().Equals(".") Then
            If Me.Text.Contains(".") Then
                e.Handled = True
            Else : e.Handled = False
            End If
        End If
    End Sub

    Private Sub txtMobile_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress
        Dim mobile As String = "0123456789+-"
        If mobile.IndexOf(e.KeyChar) = -1 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar.ToString().Equals(".") Then
            If Me.Text.Contains(".") Then
                e.Handled = True
            Else : e.Handled = False
            End If
        End If
    End Sub
End Class