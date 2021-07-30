import { Injectable } from '@angular/core';

//providenIn: root --> vai dizer que esse service pode ser usado por toda a aplicação
//Caso seja mudado para, ex: Appmodule, só será executado enquanto o appmodule estiver rodando
@Injectable({
  providedIn: 'root'
})

//Classe service é responsável pela comunicação externa ou dados que são necessário gerenciar na tela
export class TransferenciaService {


  private listaTransferencia: any[];

  constructor() {
    this.listaTransferencia = [];
  }

  get transferencia(){
    return this.listaTransferencia;
  }

  adicionar(transferencia:any){
    //const transferencia = {...$event, data: new Date()}; //{...$event} = ao invés de pegar o objeto inteiro, só pega as propriedades dele
    this.hidratar(transferencia);
    this.listaTransferencia.push(transferencia);
  }

  private hidratar(transferencia:){
    transferencia.data = new Date();
  }

}
