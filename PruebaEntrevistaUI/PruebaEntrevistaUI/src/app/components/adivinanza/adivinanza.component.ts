import { Component, OnInit } from '@angular/core';
import { Adivinanza } from 'src/app/models/adivinanza';
import { AdivinanzaService } from 'src/app/services/adivinanza.service';

@Component({
  selector: 'app-adivinanza',
  templateUrl: './adivinanza.component.html',
  styleUrls: ['./adivinanza.component.css']
})
export class AdivinanzaComponent implements OnInit {

  numeroIngresado: number;
  numeroRandom: number;
  mensaje: any;
  adivinanza: Adivinanza;

  constructor(private adivinanzaService: AdivinanzaService) {
  }

  ngOnInit() {
    this.adivinanza = {
      numeroRandom: 0,
      intentos: 0
    };
  }

  adivinarNumero(): void {
    this.adivinanzaService.enviarNumeroIngresado(this.numeroIngresado).subscribe(
      (mensaje) => {
        this.mensaje = mensaje;
      },
      (error) => {
        console.error('Error: ', error);
      }
    );
  }

  reiniciarJuego(): void{
    this.adivinanzaService.reiniciarJuego().subscribe(
      (mensaje) => {
        this.mensaje = mensaje;
      },
      (error) => {
        console.error('Error: ', error);
      }
    );
  }

}
