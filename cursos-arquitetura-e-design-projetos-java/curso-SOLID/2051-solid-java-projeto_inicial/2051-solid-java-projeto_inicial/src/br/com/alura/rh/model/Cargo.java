package br.com.alura.rh.model;

public enum Cargo {
	//Enum pode ter métodos para implementar regras de negócios
	ASSISTENTE {
		@Override
		public Cargo getProximoCargp() {
			return ANALISTA;
		}
	},
	ANALISTA {
		@Override
		public Cargo getProximoCargp() {
			return ESPECIALISTA;
		}
	},
	ESPECIALISTA {
		@Override
		public Cargo getProximoCargp() {
			return GERENTE;
		}
	},
	GERENTE {
		@Override
		public Cargo getProximoCargp() {
			return GERENTE;
		}
	};

    public abstract Cargo getProximoCargp();

}
