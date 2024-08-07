﻿using System;
using System.Collections.Generic;

namespace MediFinder_Backend.Models;

public partial class HistorialClinico
{
    public int Id { get; set; }

    public int? IdCita { get; set; }

    public string? Observaciones { get; set; }

    public string? Diagnostico { get; set; }

    public string? Padecimientos { get; set; }

    public string? Intervenciones { get; set; }

    public DateTime? Fecha { get; set; }

    public decimal? PesoPaciente { get; set; }

    public decimal? TallaPaciente { get; set; }

    public decimal? GlucosaPaciente { get; set; }

    public decimal? OxigenacionPaciente { get; set; }

    public decimal? PresionPaciente { get; set; }

    public decimal? TemperaturaCorporalPaciente { get; set; }

    public virtual Citum? IdCitaNavigation { get; set; }

    public virtual ICollection<Tratamiento> Tratamientos { get; set; } = new List<Tratamiento>();
}
