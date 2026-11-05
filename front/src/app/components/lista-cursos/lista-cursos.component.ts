import { CommonModule } from '@angular/common';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Curso } from '../../models/curso.model';

@Component({
  selector: 'app-lista-cursos',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './lista-cursos.component.html'
})
export class ListaCursosComponent {
  @Input() cursos: Curso[] = [];
  @Output() estadoCambiado = new EventEmitter<number>();
  @Output() cursoEliminado = new EventEmitter<number>();
}
