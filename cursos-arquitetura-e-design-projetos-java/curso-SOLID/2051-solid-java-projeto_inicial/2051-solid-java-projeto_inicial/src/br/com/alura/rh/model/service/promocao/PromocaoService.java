package br.com.alura.rh.model.service.promocao;

import br.com.alura.rh.ValidacaoException;
import br.com.alura.rh.model.Cargo;
import br.com.alura.rh.model.Funcionario;

public class PromocaoService{
    public void promover(Funcionario funcionario, boolean metaBatida){
        Cargo cargoAtual = funcionario.getCargo();

        if(Cargo.GERENTE == cargoAtual){
            throw new ValidacaoException("Gerentes não podem ser promovidos!");
        }

        if(metaBatida){
            Cargo novoCargo = cargoAtual.getProximoCargp();
            funcionario.promover(novoCargo);
        }
    }
}