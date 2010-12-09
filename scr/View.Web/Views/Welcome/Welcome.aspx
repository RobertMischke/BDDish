<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<WelcomeModel>" %>

<%@ Import Namespace="BDDish.View.Web" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Willkommen
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Testläufe</h2>
	<p><%= Model.FeatureTitle  %></p>
    <table>
		<tr>
			<th>Uhrzeit</th>
			<th>Features</th>
			<th>Dauer</th>
		</tr>
	</table>
	<h2>Features</h2>
	<p>
		
	</p>

	<h2>Rollen</h2>
	<p></p>
</asp:Content>
