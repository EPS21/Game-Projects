<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TwentyOneGame.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Pray game<br />
            <br />
            <asp:Button ID="playButton" runat="server" OnClick="playButton_Click" Text="Play" Width="50px" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="hitButton" runat="server" OnClick="hitButton_Click" Text="Hit " Width="50px" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="stayButton" runat="server" OnClick="stayButton_Click" Text="Stay" Width="50px" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
