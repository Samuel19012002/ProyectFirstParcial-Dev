import { Component } from '@angular/core';

@Component({
  selector: 'app-encabezado',
  standalone: true,
  templateUrl: './encabezado.component.html',
  styleUrl: './encabezado.component.css'
})
export class EncabezadoComponent {
  titulo = 'Gestion de Cursos';
  subtitulo = 'Sistema web para registrar y consultar cursos';
  asignatura = 'Desarrollo de Aplicaciones Web Avanzado';
}
