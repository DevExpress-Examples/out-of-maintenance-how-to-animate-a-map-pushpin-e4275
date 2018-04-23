Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Controls
Imports DevExpress.Xpf.Map

Namespace PushpinAnimation
	Partial Public Class MainPage
		Inherits UserControl
		Private rand As New Random(CInt(Fix(DateTime.Now.Ticks)))

		Public Sub New()
			InitializeComponent()
			SelectRandomLocation()
		End Sub

		Private Sub PushpinLocationAnimation_Completed(ByVal sender As Object, ByVal e As EventArgs)
			SelectRandomLocation()
		End Sub

		Private Sub SelectRandomLocation()
			pushpin.Location = (New GeoPoint(rand.NextDouble() * 40, rand.NextDouble() * 40))
		End Sub
	End Class
End Namespace
