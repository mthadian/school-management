Imports System.Data.SqlClient
Imports Microsoft.VisualBasic

Public Class frmLPO
    Implements StoreInterface

    Private tp As New TabPage("LPO")
    Private pForm As frmMaster

    Private Sub frmLPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pForm = Me.ParentForm
        pForm.AddTabPage(tp)
        frmMaster.ToggleControls(True)

    End Sub

    Private Sub ClearLPO()

        txtLPOMeasurement.Text = ""
        txtLPONumber.Text = ""
        txtLPOQuantity.Text = ""
        rtLPODescription.Text = ""

    End Sub

    Public Sub FormCancel() Implements StoreInterface.FormCancel
        ClearLPO()
        frmMaster.ToggleControls(True)
    End Sub

    Public Sub FormEdit() Implements StoreInterface.FormEdit
        mode = "EDIT"
        frmMaster.ToggleControls(False)
    End Sub

    Public Sub FormNew() Implements StoreInterface.FormNew
        mode = "NEW"
        ClearLPO()
        frmMaster.ToggleControls(False)
    End Sub

    Private Sub btnSubmitLPO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitLPO.Click
        Dim rsCreateLPO As New ADODB.Recordset
        sql = "select * from m_Item where v_Item_Name='" & cbxItemLPO.Text & "'"
        sql = "select * from m_LPO where pn_LPO_No='" & txtLPONumber.Text & "'"
        sql = "select * from m_LPO where n_Quantity='" & txtLPOQuantity.Text & "'"
        rsCreateLPO.Open(sql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        If rsCreateLPO.EOF Then
            rsCreateLPO.AddNew()
            rsCreateLPO("pn_LPO_No").Value = txtLPONumber.Text
            rsCreateLPO("n_Quantity").Value = txtLPOQuantity.Text
            
           
            rsCreateLPO.Update()

        End If
        ClearLPO()
        MsgBox("LPO has been submitted")
        
    End Sub

    Private Sub frmLPO_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        pForm.RemoveTabPage(tp)
    End Sub

    Private Sub SubmitLPO()



    End Sub

    Public Sub FormSubmit1() Implements StoreInterface.FormSubmit
        SubmitLPO()
    End Sub

    Public Sub FormSave() Implements StoreInterface.FormSave

    End Sub

    Private Sub txtLPOQuantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLPOQuantity.KeyPress
        Dim quantity As String = "0123456789"
        If quantity.IndexOf(e.KeyChar) = -1 And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True

        End If
        If e.KeyChar.ToString().Equals(".") Then
            If Me.Text.Contains(".") Then
                e.Handled = True
            Else : e.Handled = False
            End If

        End If

    End Sub

    Private Sub txtLPOQuantity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLPOQuantity.TextChanged

    End Sub

   

    Private Sub LoadLPOItems()
        cbxItemLPO.Items.Clear()

        Dim rs As ADODB.Recordset
        rs = New ADODB.Recordset
        sql = "Select * from m_Item where fn_Item_No='" & cbxItemLPO.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        Do While Not rs.EOF
            cbxItemLPO.Items.Add(rs("v_Item_Name").Value)
            rs.MoveNext()
        Loop
        rs = Nothing
    End Sub

    Private Sub cbxItemLPO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxItemLPO.SelectedIndexChanged
        sql = "Select * from m_Item where v_Item_Name='" & cbxItemLPO.Text & "'"
        rs.Open(sql, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        If Not rs.EOF Then
            cbxItemLPO.Text = rs("v_Item_Name").Value
        End If
        rs.Close()

        LoadLPOItems()
    End Sub
End Class