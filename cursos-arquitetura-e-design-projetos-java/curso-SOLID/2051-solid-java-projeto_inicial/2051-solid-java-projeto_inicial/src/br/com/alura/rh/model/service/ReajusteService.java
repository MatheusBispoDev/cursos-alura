package br.com.alura.rh.model.service;
import java.math.BigDecimal;
import java.util.List;
import br.com.alura.rh.model.Funcionario;

/*
    SOLID
    S - SINGLE RESPONSIBILITY PRINCIPLE
        Princípio da Responsabilidade Única (cada classe fica com uma responsabilidade específica, assim fica coesa)
        
        *Uma classe (ou módulo, função, etc) deve ter um e apenas um motivo para mudar
    O - OPEN CLOSED PRINCIPLE
        Princípio do Aberto Fechado (entidades de software, entidades entendam como classes, módulos, funções ou coisas do gênero, 
        elas deveriam estar sempre abertas para a extensão para você adicionar coisas novas, novos comportamentos, porém fechadas para modificação.)
        
        *Implementamos uma interface ReajusteService para separar as regras de negócios, assim, caso seja necessário alterar uma delas, só altera aquela regra
        específica e não outras. Caso seja necessário criar outra, criará uma nova classe herdando da interface e/ou fará um polimorfismo de algum método, assim o princípio aberto fechado é respeitado
    L -

    I -

    D -
*/

public class ReajusteService {

    private List<ValidacaoReajuste> validacoes;

    public ReajusteService(List<ValidacaoReajuste> validacoes) {
        this.validacoes = validacoes;
    }

    public void reajustarSalarioDoFuncionario(Funcionario funcionario, BigDecimal aumento) {
        // Executo cada uma das validacoes, caso alguma seja invalida vai jogar Exception
        this.validacoes.forEach(v -> v.validar(funcionario, aumento));

        BigDecimal salarioReajustado = funcionario.getSalario().add(aumento);
        funcionario.atualizaSalario(salarioReajustado);
    }

}
