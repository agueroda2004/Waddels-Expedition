using System;
using System.Collections.Generic;
using Crucero.Infraestructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Crucero.Infraestructure.Data;

public partial class WaddelsContext : DbContext
{
    public WaddelsContext(DbContextOptions<WaddelsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AplicadoPor> AplicadoPor { get; set; }

    public virtual DbSet<Barco> Barco { get; set; }

    public virtual DbSet<BarcoHabitacion> BarcoHabitacion { get; set; }

    public virtual DbSet<Complemento> Complemento { get; set; }

    public virtual DbSet<Crucero.Infraestructure.Models.Crucero> Crucero { get; set; }

    public virtual DbSet<Destino> Destino { get; set; }

    public virtual DbSet<EstadoReserva> EstadoReserva { get; set; }

    public virtual DbSet<FechasCrucero> FechasCrucero { get; set; }

    public virtual DbSet<Habitacion> Habitacion { get; set; }

    public virtual DbSet<Itinerario> Itinerario { get; set; }

    public virtual DbSet<MetodoPago> MetodoPago { get; set; }

    public virtual DbSet<Notificacion> Notificacion { get; set; }

    public virtual DbSet<Ocupantes> Ocupantes { get; set; }

    public virtual DbSet<Pago> Pago { get; set; }

    public virtual DbSet<PrecioHabitaciones> PrecioHabitaciones { get; set; }

    public virtual DbSet<Puerto> Puerto { get; set; }

    public virtual DbSet<Reserva> Reserva { get; set; }

    public virtual DbSet<ReservaComplemento> ReservaComplemento { get; set; }

    public virtual DbSet<ReservaDetalle> ReservaDetalle { get; set; }

    public virtual DbSet<Rol> Rol { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AplicadoPor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicado__3213E83F8A0A2ECA");

            entity.ToTable("Aplicado_por");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Barco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Barco__3213E83F3797B9FA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CapacidadMaxima).HasColumnName("capacidad_maxima");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<BarcoHabitacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Barco_Ha__3213E83F6D3DE5B2");

            entity.ToTable("Barco_Habitacion");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdBarco).HasColumnName("id_barco");
            entity.Property(e => e.IdHabitacion).HasColumnName("id_habitacion");

            entity.HasOne(d => d.IdBarcoNavigation).WithMany(p => p.BarcoHabitacion)
                .HasForeignKey(d => d.IdBarco)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Barco_Hab__id_ba__3D5E1FD2");

            entity.HasOne(d => d.IdHabitacionNavigation).WithMany(p => p.BarcoHabitacion)
                .HasForeignKey(d => d.IdHabitacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Barco_Hab__id_ha__3C69FB99");
        });

        modelBuilder.Entity<Complemento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Compleme__3213E83FCD471D3D");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AplicadoPorId).HasColumnName("aplicado_por_id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precio");

            entity.HasOne(d => d.AplicadoPor).WithMany(p => p.Complemento)
                .HasForeignKey(d => d.AplicadoPorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Complemen__aplic__5441852A");
        });

        modelBuilder.Entity<Crucero.Infraestructure.Models.Crucero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Crucero__3213E83F535A4A51");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BarcoId).HasColumnName("barco_id");
            entity.Property(e => e.Duracion).HasColumnName("duracion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Foto).HasColumnName("foto");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.Barco).WithMany(p => p.Crucero)
                .HasForeignKey(d => d.BarcoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Crucero__barco_i__403A8C7D");
        });

        modelBuilder.Entity<Destino>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Destino__3213E83F4EE38E89");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<EstadoReserva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Estado_R__3213E83F58669F77");

            entity.ToTable("Estado_Reserva");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<FechasCrucero>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fechas_C__3213E83FD824B047");

            entity.ToTable("Fechas_Crucero");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CruceroId).HasColumnName("crucero_id");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaInicio).HasColumnName("fecha_inicio");
            entity.Property(e => e.FehcaLimitePago).HasColumnName("fehca_limite_pago");

            entity.HasOne(d => d.Crucero).WithMany(p => p.FechasCrucero)
                .HasForeignKey(d => d.CruceroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Fechas_Cr__cruce__4BAC3F29");
        });

        modelBuilder.Entity<Habitacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Habitaci__3213E83F7E0C5FFD");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CapacidadMaxima).HasColumnName("capacidad_maxima");
            entity.Property(e => e.CapacidadMinima).HasColumnName("capacidad_minima");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Dimensiones)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dimensiones");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Itinerario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Itinerar__3213E83F4DD0E3AD");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CruceroId).HasColumnName("crucero_id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Dia)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("dia");
            entity.Property(e => e.PuertoId).HasColumnName("puerto_id");

            entity.HasOne(d => d.Crucero).WithMany(p => p.Itinerario)
                .HasForeignKey(d => d.CruceroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Itinerari__cruce__47DBAE45");

            entity.HasOne(d => d.Puerto).WithMany(p => p.Itinerario)
                .HasForeignKey(d => d.PuertoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Itinerari__puert__48CFD27E");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Metodo_P__3213E83F06349AC3");

            entity.ToTable("Metodo_Pago");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Notificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Notifica__3213E83F187617ED");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaEnvio).HasColumnName("fecha_envio");
            entity.Property(e => e.Mensaje)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mensaje");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Notificacion)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Notificac__estad__5BE2A6F2");
        });

        modelBuilder.Entity<Ocupantes>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Ocupante__3213E83FE00A58E5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.ReservaId).HasColumnName("reserva_id");

            entity.HasOne(d => d.Reserva).WithMany(p => p.Ocupantes)
                .HasForeignKey(d => d.ReservaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Ocupantes__reser__693CA210");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pago__3213E83F8B4DB587");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaPago).HasColumnName("fecha_pago");
            entity.Property(e => e.MetodoId).HasColumnName("metodo_id");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("monto");
            entity.Property(e => e.ReservaId).HasColumnName("reserva_id");
            entity.Property(e => e.TarjetaNumero).HasColumnName("tarjeta_numero");

            entity.HasOne(d => d.Metodo).WithMany(p => p.Pago)
                .HasForeignKey(d => d.MetodoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pago__metodo_id__72C60C4A");

            entity.HasOne(d => d.Reserva).WithMany(p => p.Pago)
                .HasForeignKey(d => d.ReservaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Pago__estado__71D1E811");
        });

        modelBuilder.Entity<PrecioHabitaciones>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Precio_H__3213E83FC96FAB23");

            entity.ToTable("Precio_Habitaciones");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaCruceroId).HasColumnName("fecha_crucero_id");
            entity.Property(e => e.HabitacionId).HasColumnName("habitacion_id");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precio");

            entity.HasOne(d => d.FechaCrucero).WithMany(p => p.PrecioHabitaciones)
                .HasForeignKey(d => d.FechaCruceroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Precio_Ha__fecha__4E88ABD4");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.PrecioHabitaciones)
                .HasForeignKey(d => d.HabitacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Precio_Ha__habit__4F7CD00D");
        });

        modelBuilder.Entity<Puerto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Puerto__3213E83FB7A2FA0C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DestinoId).HasColumnName("destino_id");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Pais)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pais");

            entity.HasOne(d => d.Destino).WithMany(p => p.Puerto)
                .HasForeignKey(d => d.DestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Puerto__estado__44FF419A");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reserva__3213E83F5B03238C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CantidadHabitaciones).HasColumnName("cantidad_habitaciones");
            entity.Property(e => e.CantidadPasajeros).HasColumnName("cantidad_pasajeros");
            entity.Property(e => e.EstadoId).HasColumnName("estado_id");
            entity.Property(e => e.FechaCruceroId).HasColumnName("fecha_crucero_id");
            entity.Property(e => e.Pagado)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("pagado");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("total");
            entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");

            entity.HasOne(d => d.Estado).WithMany(p => p.Reserva)
                .HasForeignKey(d => d.EstadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva__estado___628FA481");

            entity.HasOne(d => d.FechasCrucero).WithMany(p => p.Reserva)
                .HasForeignKey(d => d.FechaCruceroId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva__fecha_c__619B8048");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Reserva)
                .HasForeignKey(d => d.UsuarioId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva__usuario__60A75C0F");
        });

        modelBuilder.Entity<ReservaComplemento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reserva___3213E83FF8F5F2F7");

            entity.ToTable("Reserva_complemento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.ComplemtoId).HasColumnName("complemto_id");
            entity.Property(e => e.ReservaId).HasColumnName("reserva_id");

            entity.HasOne(d => d.Complemento).WithMany(p => p.ReservaComplemento)
                .HasForeignKey(d => d.ComplemtoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva_c__compl__6D0D32F4");

            entity.HasOne(d => d.Reserva).WithMany(p => p.ReservaComplemento)
                .HasForeignKey(d => d.ReservaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva_c__reser__6C190EBB");
        });

        modelBuilder.Entity<ReservaDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reserva___3213E83F245DC475");

            entity.ToTable("Reserva_Detalle");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.HabitacionId).HasColumnName("habitacion_id");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precio");
            entity.Property(e => e.ReservaId).HasColumnName("reserva_id");

            entity.HasOne(d => d.Habitacion).WithMany(p => p.ReservaDetalle)
                .HasForeignKey(d => d.HabitacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva_D__habit__66603565");

            entity.HasOne(d => d.Reserva).WithMany(p => p.ReservaDetalle)
                .HasForeignKey(d => d.ReservaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reserva_D__estad__656C112C");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rol__3213E83F06C58508");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3213E83FB675D983");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fecha_nacimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Pais)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.RolId).HasColumnName("rol_id");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("usuario");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuario)
                .HasForeignKey(d => d.RolId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__estado__59063A47");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
