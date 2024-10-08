﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoModelado2024.Shared.DTO
{
    public class CrearTProductoDTO
    {
        [Required(ErrorMessage = "El codigo es obligatorio")]
        [MaxLength(3, ErrorMessage = "El codigo no debe tener mas de 3 caracteres)")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(100, ErrorMessage = "El nombre debe tener mas de 100 caracteres)")]
        public string Nombre { get; set; }
    }
}
