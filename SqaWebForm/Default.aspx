<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>SQA CA WEB FORM</h1>
        <p class="lead">Enter the requested details below in order to calculate premium.</p>
    </div>
    <div class="container" style="margin:0,auto">
        <div class="container">
            <form>
                <div class="form-group">
                    <label for="iGender">Gender</label>
                    <input type="text" class="form-control" name="iGender" placeholder="Gender">
                </div>
                <div class="form-group">
                    <label for="iAge">Age</label>
                    <input type="number" class="form-control" name="iAge">
                </div>
                <button type="submit" class="btn btn-default">St</button>
            </form>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
        <div class="container">
            
            <asp:TextBox id="TextArea1" TextMode="multiline" Columns="50" Rows="5" runat="server" />
        </div>
    </div>


</asp:Content>
