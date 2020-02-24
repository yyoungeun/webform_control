<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmXml.aspx.cs" Inherits="DevStandardControl.FrmXml" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>XML 컨트롤</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Xml ID="xmlCompany" runat="server" DocumentSource="~/FrmXml.xml" TransformSource="~/FrmXml.xslt"> 
                                                                                   <%--DocumentSource: Xml컨트롤에 표시할 XML문서의 경로--%>
                                                                                   <%--TransformSource: 출력스트림에 쓰기 전에 XML문서의 서식을 지정하는 XSLT변환스타일시트의 경로--%>
            </asp:Xml>
        </div>
    </form>
</body>
</html>
