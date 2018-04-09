<%@ Page Language="C#"%>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Resenha Cultural - Blog</title>
</head>
<body>
    <h1>Página principal do blog</h1>
    <p>Artigos disponíveis</p>
    <ul>
        <%
        var lista = new List<string>
        {
            "Highway to Hell",
            "If You Want Blood",
            "TNT",
            "Thunderstruck",
        };
        var artigos = "";
        foreach(var post in lista)
        {
            artigos += $"<li>{post}</li>";
        }
        %>
        <%=artigos%>
    </ul>
</body>
</html>