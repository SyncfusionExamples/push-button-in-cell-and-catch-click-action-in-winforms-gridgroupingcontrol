Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports System
Imports System.Data
Imports System.Windows.Forms


Namespace DataGrid
	Partial Public Class Form1
		Inherits Form
		#region "Constructor"
		Public Sub New()
			InitializeComponent()
			AddHandler Me.FormClosed, AddressOf Form1_FormClosed
			Me.gridGroupingControl1.DataSource = CreateTable()
			GridSettings()
		End Sub

		#End Region

		#region "GridSettings"
		Private Sub GridSettings()
			'To set PushButton.
			Me.gridGroupingControl1.TableDescriptor.Columns(2).Appearance.AddNewRecordFieldCell.CellType = GridCellTypeName.PushButton
			Me.gridGroupingControl1.TableDescriptor.Columns(2).Appearance.AddNewRecordFieldCell.Description = "PushButton"
			'Event subscription
			AddHandler gridGroupingControl1.TableControlPushButtonClick, AddressOf gridGroupingControl1_TableControlPushButtonClick
		End Sub
		#End Region

		#Region "Event Hanlders"
		'Event Customization
		Private Sub gridGroupingControl1_TableControlPushButtonClick(ByVal sender As Object, ByVal e As GridTableControlCellPushButtonClickEventArgs)
			Dim s As String = String.Format("You clicked ({0},{1}).", e.Inner.RowIndex, e.Inner.ColIndex)
			MessageBox.Show(s)
		End Sub

		Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
			'Event unwire
			RemoveHandler gridGroupingControl1.TableControlPushButtonClick, AddressOf gridGroupingControl1_TableControlPushButtonClick
		End Sub
		#End Region

		#Region "Create DataTable"
		Private name1() As String = { "John", "Peter", "Smith", "Jay", "Krish", "Mike" }
		Private country() As String = { "UK", "USA", "Pune", "India", "China", "England" }
		Private city() As String = { "Graz", "Resende", "Bruxelles", "Aires", "Rio de janeiro", "Campinas" }
		Private scountry() As String = { "Brazil", "Belgium", "Austria", "Argentina", "France", "Beiging" }
		Private dt As New DataTable()
		Private dr As DataRow
		Private r As New Random()

		Private Function CreateTable() As DataTable
			dt.Columns.Add("Name")
			dt.Columns.Add("Id")
			dt.Columns.Add("Date")
			dt.Columns.Add("Country")
			dt.Columns.Add("Ship City")
			dt.Columns.Add("Ship Country")
			dt.Columns.Add("Freight")
			dt.Columns.Add("Postal code")
			dt.Columns.Add("Password")

			For l As Integer = 0 To 19
				dr = dt.NewRow()
				dr(0) = name1(r.Next(0, 5))
				dr(1) = "E" & r.Next(30)
				dr(2) = New DateTime(2012, 5, 23)
				dr(3) = country(r.Next(0, 5))
				dr(4) = city(r.Next(0, 5))
				dr(5) = scountry(r.Next(0, 5))
				dr(6) = r.Next(1000, 2000)
				dr(7) = r.Next(10 + (r.Next(600000, 600100)))
				dr(8) = r.Next(14000, 20000)

				dt.Rows.Add(dr)
			Next l
			Return dt
		End Function
		#End Region
	End Class
End Namespace
