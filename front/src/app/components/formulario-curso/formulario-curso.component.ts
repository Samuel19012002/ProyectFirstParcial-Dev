import { Component, EventEmitter, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Curso } from '../../models/curso.model';

@Component({
  selector: 'app-formulario-curso',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './formulario-curso.component.html'
})
export class FormularioCursoComponent {
  @Output() cursoAgregado = new EventEmitter<Omit<Curso, 'id'>>();

  nombre = '';
  docente = '';
  activo = true;

  guardar(): void {
    if (!this.nombre.trim() || !this.docente.trim()) {
      return;
    }

    this.cursoAgregado.emit({
      nombre: this.nombre.trim(),
      docente: this.docente.trim(),
      activo: this.activo
    });

    this.nombre = '';
    this.docente = '';
    this.activo = true;
  }
}
