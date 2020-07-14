<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Polak's Photo Gallery.aspx.cs" Inherits="WebApplicationPolak.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <asp:Button ID="ButtonUpload" runat="server" Text="Upload file" OnClick="ButtonUpload_Click" />
    <asp:Label ID="LabelStatus" runat="server" Text="Hello"></asp:Label>
    <asp:Repeater ID="RepeaterUserPhoto" runat="server">
 <ItemTemplate>
<img id="imgUserPhotoImg" src="<%# Container.DataItem %>"
style="width: 100px; height: 100px;" runat="server" alt="" onmouseover="preview.src=this.src"
/> </ItemTemplate>
</asp:Repeater>
    <img id="preview"
src="data:image/gif;base64,R0lGODlhAQABAIAAAP///wAAACH5B
AEAA AAALAAAAAABAAEAAAICR AEAOw==" alt="" width="400" />

</asp:Content>
