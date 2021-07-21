package br.com.alura.rh.model.service;
import java.math.BigDecimal;
import br.com.alura.rh.model.Funcionario;

public interface ValidacaoReajuste {
    void validar(Funcionario funcionario, BigDecimal aumento);
}
