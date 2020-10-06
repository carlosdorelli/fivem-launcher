Imports System.IO
Public Class Launcher
    Private Sub Logo_Click(sender As Object, e As EventArgs) Handles Logo.Click
        ' Declara o link abaixo como 'url' e depois inicia o processo
        Dim url As String = “http://www.yourwebsite.com“
        Process.Start(url)
    End Sub

    Private Sub EntrarNaCidade_Click(sender As Object, e As EventArgs) Handles EntrarNaCidade.Click
        ' Declara o ip do servidor como 'url' e depois conecta o jogador ao mesmo (não se esqueça de trocar o IP e a porta abaixo!)
        Dim url As String = “fivem://connect/IP:PORTA“
        Process.Start(url)
    End Sub

    Private Sub LimparCache_Click(sender As Object, e As EventArgs) Handles LimparCache.Click

        ' Declarando mensagens usadas nas caixas de texto
        Dim cache_encontrado = "Cache encontrado. Iniciando a limpeza!"
        Dim cache_nao_encontrado = "Cache não encontrado. Ele já está limpo!"
        Dim cache_limpo = "O cache do seu FiveM foi limpo com sucesso!"

        ' Declarando diretórios usados
        Dim cacheBrowser = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FiveM\FiveM.app\cache\browser")
        Dim cacheIpfs_Data = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FiveM\FiveM.app\cache\ipfs_data")
        Dim cachePriv = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FiveM\FiveM.app\cache\priv")
        Dim cacheServers = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FiveM\FiveM.app\cache\servers")
        Dim cacheSubprocess = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FiveM\FiveM.app\cache\subprocess")

        ' Encontrando arquivos
        If Directory.Exists(cacheBrowser) Then
            Directory.Exists(cacheIpfs_Data)
            Directory.Exists(cachePriv)
            Directory.Exists(cacheServers)
            Directory.Exists(cacheSubprocess)
            MsgBox(cache_encontrado)
            ' Deletando arquivos
            Directory.Delete(cacheBrowser, True)
            Directory.Delete(cacheIpfs_Data, True)
            Directory.Delete(cachePriv, True)
            Directory.Delete(cacheServers, True)
            Directory.Delete(cacheSubprocess, True)
            MsgBox(cache_limpo)
        Else
            ' Arquivos não encontrados
            MsgBox(cache_nao_encontrado)
        End If

    End Sub

    Private Sub Discord_Click(sender As Object, e As EventArgs) Handles Discord.Click
        ' Declara o link abaixo como 'url' e depois inicia o processo
        Dim url As String = “https://discord.gg/fKD4xAB“
        Process.Start(url)
    End Sub
End Class
