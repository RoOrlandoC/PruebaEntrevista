import { Component, OnInit } from '@angular/core';
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

  constructor(private adivinanzaService: AdivinanzaService) {
  }

  ngOnInit() { }

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
