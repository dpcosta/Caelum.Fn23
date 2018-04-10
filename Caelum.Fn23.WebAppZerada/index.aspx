<%@ Page Language="C#"%>
<%@ Import Namespace="Caelum.Fn23.WebAppZerada.Negocio" %>
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
        var lista = new List<Post>
        {
            new Post{ Id=1, Titulo="Highway to Hell", Categoria="Músicas"},
            new Post{ Id=2, Titulo="Cassino Royale", Categoria="Filmes"},
            new Post{ Id=3, Titulo="Inferno", Categoria="Livros"},
            new Post{ Id=4, Titulo="Fear of the Dark", Categoria="Músicas"},
            new Post{ Id=5, Titulo="Ciranda, Cirandinha", Categoria="Músicas"},
        };
        var artigos = "";
        foreach(var post in lista)
        {
            artigos += $"<li>{post.Titulo} - {post.Categoria}</li>";
        }
        %>
        <%=artigos%>
    </ul>
</body>
</html>