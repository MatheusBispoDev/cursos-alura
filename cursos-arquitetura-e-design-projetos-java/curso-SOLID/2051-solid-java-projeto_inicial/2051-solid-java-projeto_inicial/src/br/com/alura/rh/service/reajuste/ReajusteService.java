package br.com.alura.rh.service.reajuste;
import java.math.BigDecimal;
import java.util.List;
import br.com.alura.rh.model.Funcionario;

/*
    SOLID
    S - SINGLE RESPONSIBILITY PRINCIPLE
        Princípio da Responsabilidade Única (cada classe fica com uma responsabilidade específica, assim fica coesa)
        Cada implementação está numa classe seprada
        
        *Uma classe (ou módulo, função, etc) deve ter um e apenas um motivo para mudar

    O - OPEN CLOSED PRINCIPLE
        Princípio do Aberto Fechado (entidades de software, entidades entendam como classes, módulos, funções ou coisas do gênero, 
        elas deveriam estar sempre abertas para a extensão para você adicionar coisas novas, novos comportamentos, porém fechadas para modificação.)
        
        *Implementamos uma interface ReajusteService para separar as regras de negócios, assim, caso seja necessário alterar uma delas, só altera aquela regra
        específica e não outras. Caso seja necessário criar outra, criará uma nova classe herdando da interface e/ou fará um polimorfismo de algum método, assim o princípio aberto fechado é respeitado

    L - LISKOV SUBSTITUTION PRINCIPLE
        Se q(x) ' – , a função q(x) – ' é uma propriedade demonstrável dos objetos x do tipo T, então q(y) ' - que é um outro objeto – ' deve ser verdadeiro para objetos Y do tipo S, se S for um subtipo de T
        As classes derivadas devem ser substituíveis por suas classes bases.
        Em adição, o princípio implica que os métodos das sub-classes não podem lançar exceções não lançadas pela super-classe, exceto quando estas exceções são subtipos das exceções lançadas pelos métodos da super-classe.
        O Princípio LSP é uma extensão do Princípio Open Closed e isso significa que temos que ter certeza de que as novas classes derivadas estão estendendo as classes base, sem alterar seu comportamento.

    I - INTERFACE SEGREGATION PRINCIPLE

    D - DEPENDENCY INVERSION PRINCIPE 
        Princípio da inversão de dependências (Diminuir o acoplamento ou se acoplar com coisas mais estáveis (que mudam pouco, como interfaces))
        "Abstralções não devem depender de implementações. Implementações devem depender de abstrações." abstrações (interfaces)
        
        *Caso uma determinada implementação mude, não seremos afetados, pois dependemos apenas de sua interface.
*/

public class ReajusteService {

    private List<ValidacaoReajuste> validacoes;

    public ReajusteService(List<ValidacaoReajuste> validacoes) {
        this.validacoes = validacoes;
    }

    public void reajustarSalarioDoFuncionario(Funcionario funcionario, BigDecimal aumento) {
        // Executo cada uma das validacoes, caso alguma seja invalida vai jogar Exception
        this.validacoes.forEach(v -> v.validar(funcionario, aumento));
        
        /* //Se for feita dessa maneira respeita o Princípio da responsabilidade única (S), pois esta divida em classes
           //Mas não respeita o Princípio Aberto Fechado (O), pois a cada alteração/Acrescimo precisariamos alterar essa classe também.
           //O que não é o ideal
        ValidacaoPercentualReajuste validacaoPercentualReajuste = new ValidacaoPercentualReajuste();
        ValidacaoPeriodicidadeReajuste validacaoPeriodicidadeReajuste = new ValidacaoPeriodicidadeReajuste();

        validacaoPercentualReajuste.validar(funcionario, aumento);
        validacaoPeriodicidadeReajuste.validar(funcionario, aumento);
        */

        BigDecimal salarioReajustado = funcionario.getSalario().add(aumento);
        funcionario.atualizarSalario(salarioReajustado);
    }

}
