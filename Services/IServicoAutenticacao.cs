using RarityRoom_CSharp_WebAPI_POO.Modelos;

namespace RarityRoom.Servicos;

public interface IServicoAutenticacao
{
    Usuario Cadastrar(
        string nome,
        string email,
        string senha);

    Usuario? Entrar(
        string email,
        string senha);

    bool EmailExiste(string email);
}