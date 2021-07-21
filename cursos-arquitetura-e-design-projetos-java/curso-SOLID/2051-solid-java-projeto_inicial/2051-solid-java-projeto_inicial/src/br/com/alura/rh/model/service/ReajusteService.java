package br.com.alura.rh.model.service;

import java.math.BigDecimal;
import java.math.RoundingMode;
import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

import br.com.alura.rh.ValidacaoException;
import br.com.alura.rh.model.Funcionario;

/*
    SOLID
    S - SINGLE RESPONSIBILITY PRINCIPLE
        Princípio da responsabilidade única (cada classe fica com uma responsabilidade específica, assim fica coesa)
        *Uma classe (ou módulo, função, etc) deve ter um e apenas um motivo para mudar
*/

public class ReajusteService {

    public void reajustarSalario(Funcionario funcionario, BigDecimal aumento) {
        BigDecimal salarioAtual = funcionario.getSalario();
        BigDecimal percentualReajuste = aumento.divide(salarioAtual, RoundingMode.HALF_UP);

        if (percentualReajuste.compareTo(new BigDecimal("0.4")) > 0) {
            throw new ValidacaoException("Reajuste nao pode ser superior a 40% do salario!");
        }

        LocalDate dataUltimoReajuste = funcionario.getDataUltimoReajuste();
        LocalDate dataAtual = LocalDate.now();

        long mesesDesdeUltimoReajuste = ChronoUnit.MONTHS.between(dataUltimoReajuste, dataAtual);

        if (mesesDesdeUltimoReajuste < 6) {
            throw new ValidacaoException("Intervalo entre reajustes deve ser no minimo de 6 meses!");
        }

        BigDecimal salarioReajustado = salarioAtual.add(aumento);

        funcionario.atualizaSalario(salarioReajustado);
    }

}
