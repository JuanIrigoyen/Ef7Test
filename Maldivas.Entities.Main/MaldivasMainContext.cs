using Maldivas.Entities.Main.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Maldivas.Entities.Main
{
    public partial class MaldivasMainContext : DbContext
    {
        public MaldivasMainContext(DbContextOptions options) : base(options)
        {

        }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//            optionsBuilder.UseSqlServer(@"Server=Sealand;Database=Maldivas_Geimex;Trusted_Connection=True;");
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Agencias_transporte>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Transportistas");

                entity.ToTable("Agencias_transporte", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Bloqueo_informacion).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_operaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Clave1).HasMaxLength(20);

                entity.Property(e => e.Clave2).HasMaxLength(20);

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Fecha_alta).HasColumnType("smalldatetime");

                entity.Property(e => e.Ftp).HasMaxLength(100);

                entity.Property(e => e.Grafico).HasMaxLength(50);

                entity.Property(e => e.Horario_descarga1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_descarga2).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina2).HasColumnType("nchar(5)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Telefono3).HasMaxLength(30);

                entity.Property(e => e.Transporte_coste_minimo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transporte_factor)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transporte_fijo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transporte_indemnizacion_kg)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transporte_indemnizacion_maxima)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transporte_peso_minimo)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transporte_reexpedicion_descuento)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transporte_seguro)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transporte_seguro_minimo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transporte_tarifa_descuento)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Transporte_tipo).HasColumnType("nchar(10)");

                entity.Property(e => e.Transporte_transportista).HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Vacaciones_final).HasColumnType("nchar(5)");

                entity.Property(e => e.Vacaciones_inicio).HasColumnType("nchar(5)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);
            });

            modelBuilder.Entity<Agencias_transporte_costes_envios>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Agencias_transporte_costes_envios");

                entity.ToTable("Agencias_transporte_costes_envios", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(10)");

                entity.Property(e => e.Agencia).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Bultos).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Jaulas).HasDefaultValueSql("0");

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Palets).HasDefaultValueSql("0");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Portes_debidos).HasDefaultValueSql("0");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Reexpedicion).HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AgenciaNavigation)
                    .WithMany(p => p.Agencias_transporte_costes_envios)
                    .HasForeignKey(d => d.Agencia)
                    .HasConstraintName("FK_Agencias_transporte_costes_envios_Agencias_transporte");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Agencias_transporte_costes_envios)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Agencias_transporte_costes_envios_Clientes");
            });

            modelBuilder.Entity<Agencias_transporte_costes_trayectos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Agencias_transporte_costes_trayectos");

                entity.ToTable("Agencias_transporte_costes_trayectos", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Coste)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reexpedicion).HasDefaultValueSql("0");

                entity.Property(e => e.Trayecto).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Agencias_transporte_departamentos>(entity =>
            {
                entity.HasKey(e => new { e.Agencia, e.Tipo_departamento })
                    .HasName("PK_Agencias_transporte_departamentos");

                entity.ToTable("Agencias_transporte_departamentos", "Logistica");

                entity.Property(e => e.Agencia).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo_departamento).HasColumnType("nchar(2)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Persona_contacto).HasMaxLength(50);

                entity.HasOne(d => d.AgenciaNavigation)
                    .WithMany(p => p.Agencias_transporte_departamentos)
                    .HasForeignKey(d => d.Agencia)
                    .HasConstraintName("FK_Agencias_transporte_departamentos_Agencias_transporte");

                entity.HasOne(d => d.Tipo_departamentoNavigation)
                    .WithMany(p => p.Agencias_transporte_departamentos)
                    .HasForeignKey(d => d.Tipo_departamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Agencias_transporte_departamentos_Departamentos_tipos");
            });

            modelBuilder.Entity<Agencias_transporte_etiquetas_temporal>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Agencias_transporte_etiquetas");

                entity.ToTable("Agencias_transporte_etiquetas_temporal", "Logistica");

                entity.Property(e => e.Agencia).HasColumnType("nchar(6)");

                entity.Property(e => e.Agencia_nombre).HasMaxLength(50);

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Bultos).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Envio).HasColumnType("nchar(10)");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Kilos).HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasMaxLength(250);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Reexpedicion).HasDefaultValueSql("0");

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.Tipo_servicio).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo_transporte).HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(10)");

                entity.HasOne(d => d.EnvioNavigation)
                    .WithMany(p => p.Agencias_transporte_etiquetas_temporal)
                    .HasForeignKey(d => d.Envio)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Agencias_transporte_etiquetas_temporal_Agencias_transporte_costes_envios");
            });

            modelBuilder.Entity<Agencias_transporte_matriculas>(entity =>
            {
                entity.HasKey(e => new { e.Agencia, e.Matricula })
                    .HasName("PK_Agencias_transporte_matriculas_1");

                entity.ToTable("Agencias_transporte_matriculas", "Logistica");

                entity.Property(e => e.Agencia).HasColumnType("nchar(6)");

                entity.Property(e => e.Matricula).HasColumnType("nchar(20)");

                entity.HasOne(d => d.AgenciaNavigation)
                    .WithMany(p => p.Agencias_transporte_matriculas)
                    .HasForeignKey(d => d.Agencia)
                    .HasConstraintName("FK_Agencias_transporte_matriculas_Agencias_transporte");
            });

            modelBuilder.Entity<Agencias_transporte_tarifas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Agencias_transporte_tarifas");

                entity.ToTable("Agencias_transporte_tarifas", "Logistica");

                entity.Property(e => e.Agencia).HasColumnType("nchar(6)");

                entity.Property(e => e.Fijo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Kg_final)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Kg_inicial)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Minimo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_kg)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zona_agencia)
                    .IsRequired()
                    .HasColumnType("nchar(10)")
                    .HasDefaultValueSql("N'Zona 1'");

                entity.HasOne(d => d.AgenciaNavigation)
                    .WithMany(p => p.Agencias_transporte_tarifas)
                    .HasForeignKey(d => d.Agencia)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Agencias_transporte_tarifas_Agencias_transporte");
            });

            modelBuilder.Entity<Agencias_transporte_tipos_portes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_tipos_portes");

                entity.ToTable("Agencias_transporte_tipos_portes", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(50);
            });

            modelBuilder.Entity<Agencias_transporte_visitas>(entity =>
            {
                entity.HasKey(e => new { e.Agencia, e.Visita })
                    .HasName("PK_Agencias_transporte_visitas");

                entity.ToTable("Agencias_transporte_visitas", "Logistica");

                entity.Property(e => e.Agencia).HasColumnType("nchar(6)");

                entity.Property(e => e.Visita)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.AgenciaNavigation)
                    .WithMany(p => p.Agencias_transporte_visitas)
                    .HasForeignKey(d => d.Agencia)
                    .HasConstraintName("FK_Agencias_transporte_visitas_Agencias_transporte");
            });

            modelBuilder.Entity<Agencias_transporte_zonas>(entity =>
            {
                entity.HasKey(e => new { e.Agencia, e.Zona_agencia, e.Zona })
                    .HasName("PK_Agencias_transporte_zonas");

                entity.ToTable("Agencias_transporte_zonas", "Logistica");

                entity.Property(e => e.Agencia).HasColumnType("nchar(6)");

                entity.Property(e => e.Zona_agencia).HasColumnType("nchar(10)");

                entity.Property(e => e.Zona).HasColumnType("nchar(5)");

                entity.Property(e => e.Tiempo).HasColumnType("nchar(12)");

                entity.HasOne(d => d.AgenciaNavigation)
                    .WithMany(p => p.Agencias_transporte_zonas)
                    .HasForeignKey(d => d.Agencia)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Agencias_transporte_zonas_Agencias_transporte");

                entity.HasOne(d => d.ZonaNavigation)
                    .WithMany(p => p.Agencias_transporte_zonas)
                    .HasForeignKey(d => d.Zona)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Agencias_transporte_zonas_Clientes_zonas");
            });

            modelBuilder.Entity<Agentes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Agentes_1");

                entity.ToTable("Agentes", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Bloqueo_informacion).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_operaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Clave1).HasMaxLength(20);

                entity.Property(e => e.Clave2).HasMaxLength(20);

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Comision)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Fecha_alta).HasColumnType("smalldatetime");

                entity.Property(e => e.Ftp).HasMaxLength(100);

                entity.Property(e => e.Grafico).HasMaxLength(200);

                entity.Property(e => e.Horario_oficina1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina2).HasColumnType("nchar(5)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Internet_acceso).HasDefaultValueSql("0");

                entity.Property(e => e.Internet_grupo).HasColumnType("nchar(5)");

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Numero).HasDefaultValueSql("0");

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Telefono3).HasMaxLength(30);

                entity.Property(e => e.Tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Vacaciones_final).HasColumnType("nchar(5)");

                entity.Property(e => e.Vacaciones_inicio).HasColumnType("nchar(5)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);

                entity.Property(e => e.Zona).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Agentes_aduanas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Agentes_aduanas");

                entity.ToTable("Agentes_aduanas", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Bloqueo_informacion).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_operaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Clave1).HasMaxLength(20);

                entity.Property(e => e.Clave2).HasMaxLength(20);

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Fecha_alta).HasColumnType("smalldatetime");

                entity.Property(e => e.Ftp).HasMaxLength(100);

                entity.Property(e => e.Grafico).HasMaxLength(50);

                entity.Property(e => e.Horario_oficina1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina2).HasColumnType("nchar(5)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Numero).HasDefaultValueSql("0");

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Telefono3).HasMaxLength(30);

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);
            });

            modelBuilder.Entity<Agentes_departamentos>(entity =>
            {
                entity.HasKey(e => new { e.Agente, e.Tipo_departamento })
                    .HasName("PK_Agentes_departamentos");

                entity.ToTable("Agentes_departamentos", "Gestion");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo_departamento).HasColumnType("nchar(2)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Persona_contacto).HasMaxLength(50);

                entity.HasOne(d => d.AgenteNavigation)
                    .WithMany(p => p.Agentes_departamentos)
                    .HasForeignKey(d => d.Agente)
                    .HasConstraintName("FK_Agentes_departamentos_Agentes");

                entity.HasOne(d => d.Tipo_departamentoNavigation)
                    .WithMany(p => p.Agentes_departamentos)
                    .HasForeignKey(d => d.Tipo_departamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Agentes_departamentos_Departamentos_tipos");
            });

            modelBuilder.Entity<Agentes_direcciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Agentes_direcciones_1");

                entity.ToTable("Agentes_direcciones", "Gestion");

                entity.Property(e => e.Acceso_global).HasDefaultValueSql("0");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Clave1).HasMaxLength(50);

                entity.Property(e => e.Clave2).HasMaxLength(50);

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Email3).HasMaxLength(100);

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Ruta).HasColumnType("nchar(5)");

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Tipo)
                    .HasColumnType("nchar(2)")
                    .HasDefaultValueSql("'01'");

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);

                entity.HasOne(d => d.AgenteNavigation)
                    .WithMany(p => p.Agentes_direcciones)
                    .HasForeignKey(d => d.Agente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Agentes_direcciones_Agentes");
            });

            modelBuilder.Entity<Agentes_graficos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Agentes_graficos");

                entity.ToTable("Agentes_graficos", "Gestion");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.HasOne(d => d.AgenteNavigation)
                    .WithMany(p => p.Agentes_graficos)
                    .HasForeignKey(d => d.Agente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Agentes_graficos_Agentes");
            });

            modelBuilder.Entity<Agentes_visitas>(entity =>
            {
                entity.HasKey(e => new { e.Agente, e.Visita })
                    .HasName("PK_Agentes_visitas");

                entity.ToTable("Agentes_visitas", "Gestion");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Visita)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.AgenteNavigation)
                    .WithMany(p => p.Agentes_visitas)
                    .HasForeignKey(d => d.Agente)
                    .HasConstraintName("FK_Agentes_visitas_Agentes");
            });

            modelBuilder.Entity<Almacen>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Almacen");

                entity.ToTable("Almacen", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Comunidad).HasMaxLength(35);

                entity.Property(e => e.Cpais).HasColumnType("nchar(3)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(100);

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Email3).HasMaxLength(100);

                entity.Property(e => e.Fax1).HasMaxLength(50);

                entity.Property(e => e.Fax2).HasMaxLength(50);

                entity.Property(e => e.Horario_descarga1).HasColumnType("smalldatetime");

                entity.Property(e => e.Horario_descarga2).HasColumnType("smalldatetime");

                entity.Property(e => e.Horario_oficina1).HasColumnType("smalldatetime");

                entity.Property(e => e.Horario_oficina2).HasColumnType("smalldatetime");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Lanzamiento).HasDefaultValueSql("0");

                entity.Property(e => e.Movil1).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Pais).HasMaxLength(35);

                entity.Property(e => e.Permite_multiples_ubicaciones).HasDefaultValueSql("1");

                entity.Property(e => e.Poblacion).HasMaxLength(40);

                entity.Property(e => e.Principal).HasDefaultValueSql("0");

                entity.Property(e => e.Provincia).HasMaxLength(35);

                entity.Property(e => e.Telefono1).HasMaxLength(50);

                entity.Property(e => e.Telefono2).HasMaxLength(50);

                entity.Property(e => e.VoIp1).HasMaxLength(50);

                entity.Property(e => e.VoIp2).HasMaxLength(50);
            });

            modelBuilder.Entity<Almacen_cadena_suministro>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Almacen_cadena_suministro");

                entity.ToTable("Almacen_cadena_suministro", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Almacen_cadena_suministro_configuracion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Almacen_cadena_suministro_configuracion");

                entity.ToTable("Almacen_cadena_suministro_configuracion", "Logistica");

                entity.HasIndex(e => new { e.Almacen, e.Cadena_suministro })
                    .HasName("Idx_AlmacenCadena")
                    .IsUnique();

                entity.Property(e => e.Almacen)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.Cadena_suministro)
                    .IsRequired()
                    .HasColumnType("nchar(3)");
            });

            modelBuilder.Entity<Almacen_inventario>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Almacen_inventario");

                entity.ToTable("Almacen_inventario", "Logistica");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Descripcion).HasColumnType("nchar(200)");

                entity.Property(e => e.Existencias).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lote_externo).HasColumnType("nchar(20)");

                entity.Property(e => e.Precio_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_medio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_ultima_compra)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia_base).HasColumnType("nchar(20)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.Property(e => e.Valor)
                    .HasColumnType("money")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Almacen_ubicaciones>(entity =>
            {
                entity.HasKey(e => new { e.Almacen, e.Ubicacion })
                    .HasName("PK_Almacen_ubicaciones");

                entity.ToTable("Almacen_ubicaciones", "Logistica");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Almacen_ubicaciones)
                    .HasForeignKey(d => d.Almacen)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Almacen_ubicaciones_Almacen");
            });

            modelBuilder.Entity<Almacenes_departamentos>(entity =>
            {
                entity.HasKey(e => new { e.Almacen, e.Departamento })
                    .HasName("PK_Almacenes_departamentos");

                entity.ToTable("Almacenes_departamentos", "Logistica");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Departamento).HasColumnType("nchar(3)");
            });

            modelBuilder.Entity<Anticipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Anticipos_1");

                entity.ToTable("Anticipos", "Financiera");

                entity.Property(e => e.Completado).HasDefaultValueSql("0");

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Diferencia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa)
                    .HasColumnType("nchar(3)")
                    .HasDefaultValueSql("'EUR'");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Fecha_anticipo)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_creacion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_devolucion).HasColumnType("smalldatetime");

                entity.Property(e => e.Importe_anticipo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Importe_gastado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.Property(e => e.Saldo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subcuenta_gastos).HasColumnType("nchar(20)");

                entity.Property(e => e.Subcuenta_personal).HasColumnType("nchar(20)");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.PersonalNavigation)
                    .WithMany(p => p.Anticipos)
                    .HasForeignKey(d => d.Personal)
                    .HasConstraintName("FK_Anticipos_Personal");
            });

            modelBuilder.Entity<Areas_financieras>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores_areas");

                entity.ToTable("Areas_financieras", "Analitica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(20);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Articulos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("Idx_Codigo");

                entity.ToTable("Articulos", "Gestion");

                entity.HasIndex(e => e.Familia_ventas)
                    .HasName("Idx_FamiliaVentas");

                entity.HasIndex(e => e.Referencia_base)
                    .HasName("Idx_ReferenciaBase");

                entity.HasIndex(e => e.Tipo_competencia)
                    .HasName("Idx_TipoCompetencia");

                entity.HasIndex(e => e.Tipo_estado)
                    .HasName("Idx_TipoEstado");

                entity.HasIndex(e => e.Tipo_origen)
                    .HasName("Idx_TipoOrigen");

                entity.HasIndex(e => e.Tipo_producto)
                    .HasName("Idx_TipoProducto");

                entity.HasIndex(e => e.Ventas)
                    .HasName("Idx_Ventas");

                entity.HasIndex(e => new { e.Codigo, e.Control_stocks, e.Ventas })
                    .HasName("Idx_ControlStocksVentas");

                entity.HasIndex(e => new { e.Referencia_base, e.Tipo_origen, e.Codigo })
                    .HasName("_IdxOrigenCodigo");

                entity.HasIndex(e => new { e.Control_stocks, e.Codigo, e.Tipo_origen, e.Familia_ventas, e.Proveedor })
                    .HasName("_dta_index_Articulos_11_1238112743__K46_K1_K88_K29_K51");

                entity.HasIndex(e => new { e.Proveedor, e.Referencia_base, e.Tipo_origen, e.Control_stocks, e.Codigo })
                    .HasName("_dta_index_Articulos_11_1238112743__K46_K1_3_51_88");

                entity.HasIndex(e => new { e.Proveedor, e.Referencia_base, e.Tipo_origen, e.Codigo, e.Familia_ventas, e.Control_stocks })
                    .HasName("_dta_index_Articulos_11_1238112743__K1_K29_K46_3_51_88");

                entity.Property(e => e.Codigo).HasColumnType("nchar(20)");

                entity.Property(e => e.Actualizacion_diferida_lote).HasDefaultValueSql("0");

                entity.Property(e => e.Almacen_compras).HasColumnType("nchar(3)");

                entity.Property(e => e.Almacen_compras_ubicacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Almacen_ventas).HasColumnType("nchar(3)");

                entity.Property(e => e.Almacen_ventas_ubicacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Base).HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_totales_peso).HasDefaultValueSql("0");

                entity.Property(e => e.Catalogo).HasDefaultValueSql("0");

                entity.Property(e => e.Catalogo_orden).HasDefaultValueSql("0");

                entity.Property(e => e.Chapa_calidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Chapa_forma).HasColumnType("nchar(1)");

                entity.Property(e => e.Chapa_medida).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Complejidad).HasColumnType("nchar(1)");

                entity.Property(e => e.Compras).HasDefaultValueSql("0");

                entity.Property(e => e.Compras_lote).HasDefaultValueSql("0");

                entity.Property(e => e.Contenedor_tipo).HasColumnType("nchar(3)");

                entity.Property(e => e.Control_stocks).HasDefaultValueSql("0");

                entity.Property(e => e.Cuenta_contable).HasColumnType("nchar(20)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Descripcion_fija).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion_tarifa_nacional).HasMaxLength(100);

                entity.Property(e => e.Descriptivo).HasDefaultValueSql("0");

                entity.Property(e => e.Ean128a).HasColumnType("nchar(20)");

                entity.Property(e => e.Ean128b).HasColumnType("nchar(20)");

                entity.Property(e => e.Ean128c).HasColumnType("nchar(20)");

                entity.Property(e => e.Ean13).HasColumnType("nchar(13)");

                entity.Property(e => e.Ean13b).HasColumnType("nchar(13)");

                entity.Property(e => e.Ean39).HasColumnType("nchar(20)");

                entity.Property(e => e.Ean8).HasColumnType("nchar(8)");

                entity.Property(e => e.Estado).HasColumnType("nchar(1)");

                entity.Property(e => e.Excluir).HasDefaultValueSql("0");

                entity.Property(e => e.Existencias).HasDefaultValueSql("0");

                entity.Property(e => e.Fabricacion_lote).HasDefaultValueSql("0");

                entity.Property(e => e.Fabricante).HasColumnType("nchar(4)");

                entity.Property(e => e.Familia_compras).HasColumnType("nchar(4)");

                entity.Property(e => e.Familia_medio_ambiente).HasColumnType("nchar(4)");

                entity.Property(e => e.Familia_ventas).HasColumnType("nchar(4)");

                entity.Property(e => e.Fecha_alta).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_baja).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_creacion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fin_produccion).HasDefaultValueSql("0");

                entity.Property(e => e.Imagen_estructura).HasDefaultValueSql("-1");

                entity.Property(e => e.Iva).HasColumnType("nchar(10)");

                entity.Property(e => e.Iva_contabilidad).HasColumnType("nchar(3)");

                entity.Property(e => e.Jaulas).HasDefaultValueSql("0");

                entity.Property(e => e.Lanzamiento_supermercado).HasDefaultValueSql("0");

                entity.Property(e => e.Laser).HasDefaultValueSql("0");

                entity.Property(e => e.Lead_time).HasDefaultValueSql("3");

                entity.Property(e => e.Mano).HasColumnType("nchar(25)");

                entity.Property(e => e.Marca).HasMaxLength(50);

                entity.Property(e => e.Materia_prima).HasColumnType("nchar(3)");

                entity.Property(e => e.Medida).HasColumnType("nchar(10)");

                entity.Property(e => e.Medidas_alto).HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_altura_1).HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_altura_2).HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_ancho)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_base_inferior).HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_base_superior).HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_diagonal).HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_espesor)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_largo)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_largo_c)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_paso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Medidas_radio)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modelo).HasMaxLength(50);

                entity.Property(e => e.Novedad_fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Novedad_fecha_inicial).HasColumnType("smalldatetime");

                entity.Property(e => e.Novedad_observaciones).HasMaxLength(240);

                entity.Property(e => e.Numero_serie).HasColumnType("nchar(30)");

                entity.Property(e => e.Oferta).HasDefaultValueSql("0");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Piezas_por_formato).HasDefaultValueSql("0");

                entity.Property(e => e.Plancha).HasColumnType("nchar(20)");

                entity.Property(e => e.Plazo_aprovisionamiento).HasDefaultValueSql("0");

                entity.Property(e => e.Plazo_garantia).HasDefaultValueSql("0");

                entity.Property(e => e.Plazo_seguridad).HasDefaultValueSql("0");

                entity.Property(e => e.Precio_certificada)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_costo_fabricacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_inversion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_medio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_ultima_compra)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_ultimo_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_venta_publico_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Punto_muerto_piezas_actuales).HasDefaultValueSql("0");

                entity.Property(e => e.Punto_muerto_piezas_iniciales).HasDefaultValueSql("0");

                entity.Property(e => e.Referencia_auxiliar).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_base).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_certificada).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_certificada_hs).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_certificada_thatcham).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_certificada_tuv).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_fabricación).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_francesa).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_israelita).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_medio_ambiente).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_original).HasColumnType("nchar(40)");

                entity.Property(e => e.Serie_minima_rentable).HasDefaultValueSql("0");

                entity.Property(e => e.Stock_minimo).HasDefaultValueSql("0");

                entity.Property(e => e.Stock_seguridad).HasDefaultValueSql("0");

                entity.Property(e => e.Subfamilia_compras).HasColumnType("nchar(4)");

                entity.Property(e => e.Subfamilia_ventas).HasColumnType("nchar(4)");

                entity.Property(e => e.Tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_acabado).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo_calidad).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo_carroceria).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_cataforesis).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_competencia).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo_estado).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo_gestion).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_informatica).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_logistica).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_mantenimiento).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_matriceria).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_montaje).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo_oficina).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_origen).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo_produccion).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo_producto).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo_suministro).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo_troqueles).HasColumnType("nchar(3)");

                entity.Property(e => e.Unidad_caja).HasDefaultValueSql("0");

                entity.Property(e => e.Unidad_medida_almacen).HasColumnType("nchar(20)");

                entity.Property(e => e.Unidad_medida_compra).HasColumnType("nchar(20)");

                entity.Property(e => e.Unidad_medida_venta).HasColumnType("nchar(20)");

                entity.Property(e => e.Unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_ordenadas).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_reservadas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_lote).HasDefaultValueSql("0");

                entity.Property(e => e.Version).HasMaxLength(50);

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Chapa_calidadNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.Chapa_calidad)
                    .HasConstraintName("FK_Articulos_Articulos_chapa_calidad");

                entity.HasOne(d => d.Chapa_formaNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.Chapa_forma)
                    .HasConstraintName("FK_Articulos_Articulos_chapa_forma");

                entity.HasOne(d => d.Chapa_medidaNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.Chapa_medida)
                    .HasConstraintName("FK_Articulos_Articulos_chapa_medida");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Articulos)
                    .HasForeignKey(d => d.Proveedor)
                    .HasConstraintName("FK_Articulos_Proveedores");
            });

            modelBuilder.Entity<Articulos_acabados>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_acabados");

                entity.ToTable("Articulos_acabados", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_almacen_ubicacion_predeterminada>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Almacen })
                    .HasName("PK_Articulos_almacen_ubicacion_predeterminada_1");

                entity.ToTable("Articulos_almacen_ubicacion_predeterminada", "Logistica");

                entity.HasIndex(e => e.Almacen)
                    .HasName("Idx_Almacen");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_Articulo");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Articulos_almacen_ubicacion_predeterminada)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Articulos_almacen_ubicacion_predeterminada_Almacen");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_almacen_ubicacion_predeterminada)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_almacen_ubicacion_predeterminada_Articulos");
            });

            modelBuilder.Entity<Articulos_calculo_punto_pedido>(entity =>
            {
                entity.HasKey(e => e.Articulo)
                    .HasName("PK_Articulos_calculo_punto_pedido");

                entity.ToTable("Articulos_calculo_punto_pedido", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Ejercicio1).HasColumnType("nchar(4)");

                entity.Property(e => e.Ejercicio10).HasColumnType("nchar(4)");

                entity.Property(e => e.Ejercicio2).HasColumnType("nchar(4)");

                entity.Property(e => e.Ejercicio3).HasColumnType("nchar(4)");

                entity.Property(e => e.Ejercicio4).HasColumnType("nchar(4)");

                entity.Property(e => e.Ejercicio5).HasColumnType("nchar(4)");

                entity.Property(e => e.Ejercicio6).HasColumnType("nchar(4)");

                entity.Property(e => e.Ejercicio7).HasColumnType("nchar(4)");

                entity.Property(e => e.Ejercicio8).HasColumnType("nchar(4)");

                entity.Property(e => e.Ejercicio9).HasColumnType("nchar(4)");

                entity.Property(e => e.Familia).HasColumnType("nchar(4)");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Interlocutor).HasColumnType("nchar(6)");

                entity.Property(e => e.Lote_fabricacion).HasDefaultValueSql("0");

                entity.Property(e => e.Media).HasDefaultValueSql("0");

                entity.Property(e => e.Mes1).HasDefaultValueSql("0");

                entity.Property(e => e.Mes10).HasDefaultValueSql("0");

                entity.Property(e => e.Mes11).HasDefaultValueSql("0");

                entity.Property(e => e.Mes12).HasDefaultValueSql("0");

                entity.Property(e => e.Mes2).HasDefaultValueSql("0");

                entity.Property(e => e.Mes3).HasDefaultValueSql("0");

                entity.Property(e => e.Mes4).HasDefaultValueSql("0");

                entity.Property(e => e.Mes5).HasDefaultValueSql("0");

                entity.Property(e => e.Mes6).HasDefaultValueSql("0");

                entity.Property(e => e.Mes7).HasDefaultValueSql("0");

                entity.Property(e => e.Mes8).HasDefaultValueSql("0");

                entity.Property(e => e.Mes9).HasDefaultValueSql("0");

                entity.Property(e => e.Stock_minimo).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_origen).HasColumnType("nchar(2)");

                entity.Property(e => e.TotalMeses).HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithOne(p => p.Articulos_calculo_punto_pedido)
                    .HasForeignKey<Articulos_calculo_punto_pedido>(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_calculo_punto_pedido_Articulos");
            });

            modelBuilder.Entity<Articulos_catalogo_repetidos>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Subfamilia })
                    .HasName("PK_Articulos_catalogo_repetidos");

                entity.ToTable("Articulos_catalogo_repetidos", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Subfamilia).HasColumnType("nchar(5)");

                entity.Property(e => e.Orden_catalogo).HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_catalogo_repetidos)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_catalogo_repetidos_Articulos");
            });

            modelBuilder.Entity<Articulos_centro_coste_porcentaje>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Centro_Coste })
                    .HasName("PK_Articulos_centrocoste_porcentaje");

                entity.ToTable("Articulos_centro_coste_porcentaje", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Centro_Coste).HasColumnType("nchar(2)");
            });

            modelBuilder.Entity<Articulos_certificaciones>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Certificacion })
                    .HasName("PK_Articulos_certificaciones");

                entity.ToTable("Articulos_certificaciones", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Certificacion).HasColumnType("nchar(2)");

                entity.Property(e => e.Documento).HasMaxLength(100);

                entity.Property(e => e.Fecha_caducidad).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicial).HasColumnType("smalldatetime");

                entity.Property(e => e.Propietario).HasColumnType("nchar(6)");

                entity.Property(e => e.Referencia).HasColumnType("nchar(20)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_certificaciones)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_certificaciones_Articulos");
            });

            modelBuilder.Entity<Articulos_chapa_acabado>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_chapa_acabado");

                entity.ToTable("Articulos_chapa_acabado", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Especificacion).HasColumnType("nchar(1)");
            });

            modelBuilder.Entity<Articulos_chapa_aspecto>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_chapa_aspecto");

                entity.ToTable("Articulos_chapa_aspecto", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Especificacion).HasColumnType("nchar(1)");

                entity.Property(e => e.Observaciones).HasColumnType("nchar(2000)");
            });

            modelBuilder.Entity<Articulos_chapa_calidad>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_chapa_calidad");

                entity.ToTable("Articulos_chapa_calidad", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(4)");

                entity.Property(e => e.Acabado).HasColumnType("nchar(2)");

                entity.Property(e => e.Aspecto).HasColumnType("nchar(2)");

                entity.Property(e => e.Densidad)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Embuticion).HasColumnType("nchar(2)");

                entity.Property(e => e.Limite_elastico_re).HasDefaultValueSql("0");

                entity.Property(e => e.Norma).HasColumnType("nchar(2)");

                entity.Property(e => e.Recubrimiento).HasColumnType("nchar(2)");

                entity.Property(e => e.Tratamiento).HasColumnType("nchar(2)");

                entity.HasOne(d => d.AcabadoNavigation)
                    .WithMany(p => p.Articulos_chapa_calidad)
                    .HasForeignKey(d => d.Acabado)
                    .HasConstraintName("FK_Articulos_chapa_calidad_Articulos_chapa_acabado");

                entity.HasOne(d => d.AspectoNavigation)
                    .WithMany(p => p.Articulos_chapa_calidad)
                    .HasForeignKey(d => d.Aspecto)
                    .HasConstraintName("FK_Articulos_chapa_calidad_Articulos_chapa_aspecto");

                entity.HasOne(d => d.EmbuticionNavigation)
                    .WithMany(p => p.Articulos_chapa_calidad)
                    .HasForeignKey(d => d.Embuticion)
                    .HasConstraintName("FK_Articulos_chapa_calidad_Articulos_chapa_embuticion");

                entity.HasOne(d => d.NormaNavigation)
                    .WithMany(p => p.Articulos_chapa_calidad)
                    .HasForeignKey(d => d.Norma)
                    .HasConstraintName("FK_Articulos_chapa_calidad_Normas");

                entity.HasOne(d => d.RecubrimientoNavigation)
                    .WithMany(p => p.Articulos_chapa_calidad)
                    .HasForeignKey(d => d.Recubrimiento)
                    .HasConstraintName("FK_Articulos_chapa_calidad_Articulos_chapa_recubrimiento");

                entity.HasOne(d => d.TratamientoNavigation)
                    .WithMany(p => p.Articulos_chapa_calidad)
                    .HasForeignKey(d => d.Tratamiento)
                    .HasConstraintName("FK_Articulos_chapa_calidad_Articulos_chapa_tratamiento");
            });

            modelBuilder.Entity<Articulos_chapa_embuticion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_chapa_embuticion");

                entity.ToTable("Articulos_chapa_embuticion", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Embuticion).HasMaxLength(50);

                entity.Property(e => e.Espeficicacion).HasMaxLength(10);
            });

            modelBuilder.Entity<Articulos_chapa_forma>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_chapa_forma");

                entity.ToTable("Articulos_chapa_forma", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(1)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_chapa_medida>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_chapa_medida");

                entity.ToTable("Articulos_chapa_medida", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Ancho_A)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Espesor_E)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Largo_B)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Largo_C)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Paso_P)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Radio_R)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Articulos_chapa_recubrimiento>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_chapa_recubrimiento");

                entity.ToTable("Articulos_chapa_recubrimiento", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Espeficicacion).HasMaxLength(20);

                entity.Property(e => e.Recubrimiento).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_chapa_tratamiento>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_chapa_tratamiento");

                entity.ToTable("Articulos_chapa_tratamiento", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Especificacion).HasColumnType("nchar(1)");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Articulos_clasificacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_departamentos");

                entity.ToTable("Articulos_clasificacion", "Gestion");

                entity.HasIndex(e => e.Descripcion)
                    .HasName("Descripcion")
                    .IsUnique();

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnType("nchar(30)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Articulos_clasificacion_relacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_departamentos_1");

                entity.ToTable("Articulos_clasificacion_relacion", "Gestion");

                entity.HasIndex(e => new { e.Departamento, e.Articulo })
                    .HasName("_dta_index_Articulos_clasificacion_relacion_11_1487656693__K2_K1")
                    .IsUnique();

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Departamento)
                    .IsRequired()
                    .HasColumnType("nchar(2)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_clasificacion_relacion)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_clasificacion_relacion_Articulos");

                entity.HasOne(d => d.DepartamentoNavigation)
                    .WithMany(p => p.Articulos_clasificacion_relacion)
                    .HasForeignKey(d => d.Departamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_clasificacion_relacion_Articulos_clasificacion");
            });

            modelBuilder.Entity<Articulos_compatibles>(entity =>
            {
                entity.HasKey(e => new { e.Articulo_chapa, e.Articulo })
                    .HasName("PK_Articulos_compatibles");

                entity.ToTable("Articulos_compatibles", "Carroceria");

                entity.Property(e => e.Articulo_chapa).HasColumnType("nchar(20)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");
            });

            modelBuilder.Entity<Articulos_competidores_acuerdos>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Competidor, e.Fecha_inicial })
                    .HasName("PK_Articulos_competidores_acuerdos");

                entity.ToTable("Articulos_competidores_acuerdos", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Competidor).HasColumnType("nchar(6)");

                entity.Property(e => e.Fecha_inicial).HasColumnType("smalldatetime");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Estado).HasColumnType("nchar(20)");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Observaciones).HasMaxLength(250);

                entity.Property(e => e.Precio_minimo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_competidores_acuerdos)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_competidores_acuerdos_Articulos");
            });

            modelBuilder.Entity<Articulos_conjuntos>(entity =>
            {
                entity.HasKey(e => new { e.Padre, e.Hijo })
                    .HasName("PK_Articulos_conjuntos");

                entity.ToTable("Articulos_conjuntos", "Gestion");

                entity.HasIndex(e => e.Hijo)
                    .HasName("IDX_Hijo");

                entity.HasIndex(e => e.Orden)
                    .HasName("IDX_Orden");

                entity.HasIndex(e => e.Padre)
                    .HasName("IDX_Padre");

                entity.Property(e => e.Padre).HasColumnType("nchar(20)");

                entity.Property(e => e.Hijo).HasColumnType("nchar(20)");

                entity.Property(e => e.Desperdicio).HasDefaultValueSql("0");

                entity.Property(e => e.Fabricacion_lotes).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_alta).HasColumnType("datetime");

                entity.Property(e => e.Fecha_final_ingenieria).HasColumnType("datetime");

                entity.Property(e => e.Fecha_inicio_ingenieria).HasColumnType("datetime");

                entity.Property(e => e.Fecha_ultima_modificacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Generar_pedido).HasDefaultValueSql("1");

                entity.Property(e => e.Orden).HasDefaultValueSql("0");

                entity.Property(e => e.Perdida_preparacion).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_netas).HasDefaultValueSql("0");

                entity.Property(e => e.Verificar_stock).HasDefaultValueSql("0");

                entity.HasOne(d => d.HijoNavigation)
                    .WithMany(p => p.Articulos_conjuntosHijoNavigation)
                    .HasForeignKey(d => d.Hijo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_conjuntos_Articulos1");

                entity.HasOne(d => d.PadreNavigation)
                    .WithMany(p => p.Articulos_conjuntosPadreNavigation)
                    .HasForeignKey(d => d.Padre)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_conjuntos_Articulos");
            });

            modelBuilder.Entity<Articulos_consumos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_consumos_1");

                entity.ToTable("Articulos_consumos", "Gestion");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Articulo_imputado).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro).HasColumnType("nchar(6)");

                entity.Property(e => e.Departamento).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Maquina).HasColumnType("nchar(5)");

                entity.Property(e => e.Precio).HasColumnType("decimal");

                entity.Property(e => e.Troquel).HasColumnType("nchar(20)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Articulos_contenedores_capacidad>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_contenedores_medidas");

                entity.ToTable("Articulos_contenedores_capacidad", "Logistica");

                entity.HasIndex(e => new { e.Articulo, e.Contenedor_tipo })
                    .HasName("Idx_ArticuloContenedorTipo")
                    .IsUnique();

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Contenedor_tipo)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_contenedores_capacidad)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_contenedores_medidas_Articulos");

                entity.HasOne(d => d.Contenedor_tipoNavigation)
                    .WithMany(p => p.Articulos_contenedores_capacidad)
                    .HasForeignKey(d => d.Contenedor_tipo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_contenedores_medidas_Contenedores_tipos");
            });

            modelBuilder.Entity<Articulos_embalajes>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Embalaje })
                    .HasName("PK_Articulos_embalajes");

                entity.ToTable("Articulos_embalajes", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Embalaje).HasColumnType("nchar(3)");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_embalajes)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_embalajes_Articulos");

                entity.HasOne(d => d.EmbalajeNavigation)
                    .WithMany(p => p.Articulos_embalajes)
                    .HasForeignKey(d => d.Embalaje)
                    .HasConstraintName("FK_Articulos_embalajes_Embalajes");
            });

            modelBuilder.Entity<Articulos_embo_uk>(entity =>
            {
                entity.HasKey(e => e.Referencia)
                    .HasName("PK_Articulos_embo_uk");

                entity.ToTable("Articulos_embo_uk", "Gestion");

                entity.Property(e => e.Referencia).HasColumnType("nchar(14)");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Articulos_estados>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_estados_1");

                entity.ToTable("Articulos_estados", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_estados_fabricacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_estados");

                entity.ToTable("Articulos_estados_fabricacion", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(1)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(50)");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Articulos_etiquetas_idiomas>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Idioma })
                    .HasName("PK_Idiomas_etiquetas");

                entity.ToTable("Articulos_etiquetas_idiomas", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Traduccion).HasMaxLength(200);

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_etiquetas_idiomas)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_etiquetas_idiomas_Articulos");

                entity.HasOne(d => d.IdiomaNavigation)
                    .WithMany(p => p.Articulos_etiquetas_idiomas)
                    .HasForeignKey(d => d.Idioma)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_etiquetas_idiomas_Lenguajes");
            });

            modelBuilder.Entity<Articulos_familias_compras>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_FAMILIAS$");

                entity.ToTable("Articulos_familias_compras", "Gestion");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Familia).HasColumnType("nchar(4)");

                entity.Property(e => e.Grafico).HasMaxLength(100);

                entity.Property(e => e.Nivel).HasColumnType("nchar(1)");

                entity.Property(e => e.Observaciones).HasMaxLength(1000);
            });

            modelBuilder.Entity<Articulos_familias_medio_ambiente>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_familias_medio_ambiente");

                entity.ToTable("Articulos_familias_medio_ambiente", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(4)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<Articulos_familias_ventas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_familias_ventas_1");

                entity.ToTable("Articulos_familias_ventas", "Gestion");

                entity.HasIndex(e => e.Familia)
                    .HasName("Idx_familia");

                entity.HasIndex(e => e.Nivel)
                    .HasName("Idx_nivel");

                entity.Property(e => e.Color).HasColumnType("nchar(3)");

                entity.Property(e => e.Espanol).HasMaxLength(50);

                entity.Property(e => e.Familia).HasColumnType("nchar(4)");

                entity.Property(e => e.Grafico).HasMaxLength(100);

                entity.Property(e => e.Hand).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Mano).HasColumnType("nchar(10)");

                entity.Property(e => e.Nivel).HasColumnType("nchar(1)");

                entity.Property(e => e.Observaciones).HasMaxLength(254);

                entity.Property(e => e.Orden_familia).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_pieza).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_subfamilia).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Articulos_familias_ventas_idiomas>(entity =>
            {
                entity.HasKey(e => new { e.Familia, e.Idioma })
                    .HasName("PK_Idiomas_familias_ventas");

                entity.ToTable("Articulos_familias_ventas_idiomas", "Gestion");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Traduccion).HasMaxLength(254);

                entity.HasOne(d => d.FamiliaNavigation)
                    .WithMany(p => p.Articulos_familias_ventas_idiomas)
                    .HasForeignKey(d => d.Familia)
                    .HasConstraintName("FK_Articulos_familias_ventas_idiomas_Articulos_familias_ventas");

                entity.HasOne(d => d.IdiomaNavigation)
                    .WithMany(p => p.Articulos_familias_ventas_idiomas)
                    .HasForeignKey(d => d.Idioma)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_familias_ventas_idiomas_Lenguajes");
            });

            modelBuilder.Entity<Articulos_familias_ventas_multiples>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Subfamilia })
                    .HasName("PK_Articulos_familias_venta_multiples");

                entity.ToTable("Articulos_familias_ventas_multiples", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Subfamilia).HasColumnType("nchar(4)");

                entity.Property(e => e.Descripcion_tarifa_nacional).HasMaxLength(100);

                entity.Property(e => e.Referencia_original).HasColumnType("nchar(20)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_familias_ventas_multiples)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_familias_venta_multiples_Articulos");
            });

            modelBuilder.Entity<Articulos_familias_ventas_multiples_idiomas>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Subfamilia, e.Idioma })
                    .HasName("PK_Articulos_familias_ventas_multiples_idiomas");

                entity.ToTable("Articulos_familias_ventas_multiples_idiomas", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Subfamilia).HasColumnType("nchar(4)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.HasOne(d => d.Articulos_familias_ventas_multiples)
                    .WithMany(p => p.Articulos_familias_ventas_multiples_idiomas)
                    .HasForeignKey(d => new { d.Articulo, d.Subfamilia })
                    .HasConstraintName("FK_Articulos_familias_ventas_multiples_idiomas_Articulos_familias_ventas_multiples");
            });

            modelBuilder.Entity<Articulos_fases>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Fase })
                    .HasName("PK_Articulos_fases");

                entity.ToTable("Articulos_fases", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(6)");

                entity.Property(e => e.Centro_destino).HasColumnType("nchar(6)");

                entity.Property(e => e.Centro_predeterminado).HasDefaultValueSql("1");

                entity.Property(e => e.Centro_produccion).HasColumnType("nchar(6)");

                entity.Property(e => e.Ciclos_hora).HasDefaultValueSql("0");

                entity.Property(e => e.Cierre_reserva).HasDefaultValueSql("0");

                entity.Property(e => e.Codigo_versiones).HasColumnType("nchar(10)");

                entity.Property(e => e.Generar_ot).HasDefaultValueSql("0");

                entity.Property(e => e.Operarios_fase).HasDefaultValueSql("0");

                entity.Property(e => e.Orden).HasDefaultValueSql("0");

                entity.Property(e => e.Piezas_ciclo).HasDefaultValueSql("0");

                entity.Property(e => e.Tiempo_fase).HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_fases)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_fases_Articulos");

                entity.HasOne(d => d.Centro_costeNavigation)
                    .WithMany(p => p.Articulos_fases)
                    .HasForeignKey(d => d.Centro_coste)
                    .HasConstraintName("FK_Articulos_fases_Centros");

                entity.HasOne(d => d.Centro_produccionNavigation)
                    .WithMany(p => p.Articulos_fases)
                    .HasForeignKey(d => d.Centro_produccion)
                    .HasConstraintName("FK_Articulos_fases_Centros_captor");

                entity.HasOne(d => d.FaseNavigation)
                    .WithMany(p => p.Articulos_fases)
                    .HasForeignKey(d => d.Fase)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_fases_Fases");
            });

            modelBuilder.Entity<Articulos_formatos_tipo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_formatos_tipo");

                entity.ToTable("Articulos_formatos_tipo", "Calidad");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Articulos_graficos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_graficos");

                entity.ToTable("Articulos_graficos", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Numero).HasDefaultValueSql("1");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_graficos)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Articulos_graficos_Articulos");
            });

            modelBuilder.Entity<Articulos_guia_tasaciones>(entity =>
            {
                entity.HasKey(e => e.Codaux)
                    .HasName("PK_Articulos_guia_tasaciones");

                entity.ToTable("Articulos_guia_tasaciones", "Gestion");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasColumnType("nchar(2)")
                    .HasDefaultValueSql("'ES'");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasColumnType("nchar(20)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_guia_tasaciones)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_guia_tasaciones_Articulos");
            });

            modelBuilder.Entity<Articulos_idiomas>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Idioma })
                    .HasName("PK_Idiomas_articulos");

                entity.ToTable("Articulos_idiomas", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Traduccion).HasMaxLength(200);

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_idiomas)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_idiomas_Articulos");

                entity.HasOne(d => d.IdiomaNavigation)
                    .WithMany(p => p.Articulos_idiomas)
                    .HasForeignKey(d => d.Idioma)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_idiomas_Lenguajes");
            });

            modelBuilder.Entity<Articulos_imagenes>(entity =>
            {
                entity.HasKey(e => e.Codaux)
                    .HasName("PK_Articulos_imagenes");

                entity.ToTable("Articulos_imagenes", "Carroceria");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Articulos_imagenes)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_imagenes_Articulo");
            });

            modelBuilder.Entity<Articulos_lote_fabricacion>(entity =>
            {
                entity.HasKey(e => e.Articulo)
                    .HasName("PK_Articulos_lote_fabricacion");

                entity.ToTable("Articulos_lote_fabricacion", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");
            });

            modelBuilder.Entity<Articulos_lotes>(entity =>
            {
                entity.HasKey(e => e.Lote)
                    .HasName("PK_Articulos_lotes");

                entity.ToTable("Articulos_lotes", "Logistica");

                entity.HasIndex(e => e.Cantidad)
                    .HasName("Idx_Cantidad");

                entity.HasIndex(e => e.Orden_trabajo)
                    .HasName("Idx_OrdenTrabajo");

                entity.HasIndex(e => new { e.Etiqueta, e.Proveedor })
                    .HasName("Idx_Etiqueta");

                entity.HasIndex(e => new { e.Lote_externo, e.Proveedor })
                    .HasName("Idx_LoteExterno")
                    .IsUnique();

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Calidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Captor).HasDefaultValueSql("0");

                entity.Property(e => e.Centro_trabajo).HasColumnType("nchar(6)");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Etiqueta).HasColumnType("nchar(20)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Importado).HasDefaultValueSql("0");

                entity.Property(e => e.Lote_externo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Lote_proveedor).HasColumnType("nchar(20)");

                entity.Property(e => e.Maquina).HasColumnType("nchar(5)");

                entity.Property(e => e.Observaciones).HasMaxLength(250);

                entity.Property(e => e.Operacion).HasDefaultValueSql("0");

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Tipo).HasDefaultValueSql("1");

                entity.Property(e => e.Ubicacion)
                    .HasColumnType("nchar(5)")
                    .HasDefaultValueSql("N'LIBRE'");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Albaran_comprasNavigation)
                    .WithMany(p => p.Articulos_lotes)
                    .HasForeignKey(d => d.Albaran_compras)
                    .HasConstraintName("FK_Articulos_lotes_Compras_albaranes_cabecera");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_lotes)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_lotes_Articulos");

                entity.HasOne(d => d.CalidadNavigation)
                    .WithMany(p => p.Articulos_lotes)
                    .HasForeignKey(d => d.Calidad)
                    .HasConstraintName("FK_Articulos_lotes_Articulos_chapa_calidad");

                entity.HasOne(d => d.Pedido_comprasNavigation)
                    .WithMany(p => p.Articulos_lotes)
                    .HasForeignKey(d => d.Pedido_compras)
                    .HasConstraintName("FK_Articulos_lotes_Compras_pedidos_cabecera");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Articulos_lotes)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_lotes_Proveedores");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Articulos_lotes)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_lotes_Articulos_lotes_tipos");
            });

            modelBuilder.Entity<Articulos_lotes_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_lotes_tipos");

                entity.ToTable("Articulos_lotes_tipos", "Logistica");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<Articulos_medidas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_medidas");

                entity.ToTable("Articulos_medidas", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Abreviatura).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Articulos_montajes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_montajes");

                entity.ToTable("Articulos_montajes", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_movimientos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_movimientos");

                entity.ToTable("Articulos_movimientos", "Logistica");

                entity.HasIndex(e => e.Almacen)
                    .HasName("Idx_Almacen");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_Articulo");

                entity.HasIndex(e => e.Documento_codigo)
                    .HasName("Idx_Documento");

                entity.HasIndex(e => e.Documento_tipo)
                    .HasName("Idx_DocumentoTipo");

                entity.HasIndex(e => e.Lote)
                    .HasName("Idx_Lote");

                entity.HasIndex(e => new { e.Articulo, e.Almacen })
                    .HasName("Cix_ArticuloAlmacen");

                entity.HasIndex(e => new { e.Articulo, e.Almacen, e.Ubicacion, e.Lote })
                    .HasName("Idx_ArticuloAlmacenUbicacionLote");

                entity.Property(e => e.Almacen)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Documento_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Documento_tipo).HasColumnType("nchar(2)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Operario).HasColumnType("nchar(5)");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Reservado).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnType("nchar(2)")
                    .HasDefaultValueSql("'01'");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_movimientos)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_movimientos_Articulos");

                entity.HasOne(d => d.Documento_tipoNavigation)
                    .WithMany(p => p.Articulos_movimientos)
                    .HasForeignKey(d => d.Documento_tipo)
                    .HasConstraintName("FK_Articulos_movimientos_Articulos_movimientos_documentos_tipos");

                entity.HasOne(d => d.LoteNavigation)
                    .WithMany(p => p.Articulos_movimientos)
                    .HasForeignKey(d => d.Lote)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Articulos_movimientos_Articulos_lotes");

                entity.HasOne(d => d.OperarioNavigation)
                    .WithMany(p => p.Articulos_movimientos)
                    .HasForeignKey(d => d.Operario)
                    .HasConstraintName("FK_Articulos_movimientos_Personal");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Articulos_movimientos)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_movimientos_Articulos_movimientos_tipos");

                entity.HasOne(d => d.Almacen_ubicaciones)
                    .WithMany(p => p.Articulos_movimientos)
                    .HasForeignKey(d => new { d.Almacen, d.Ubicacion })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_movimientos_Almacen_ubicaciones1");
            });

            modelBuilder.Entity<Articulos_movimientos_documentos_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_movimientos_documentos_tipos");

                entity.ToTable("Articulos_movimientos_documentos_tipos", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripciones).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_movimientos_historico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_movimientos_historico");

                entity.ToTable("Articulos_movimientos_historico", "Logistica");

                entity.Property(e => e.Almacen)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Documento_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Documento_tipo).HasColumnType("nchar(2)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Operario).HasColumnType("nchar(5)");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Reservado).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnType("nchar(2)")
                    .HasDefaultValueSql("'01'");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Articulos_movimientos_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tipos_movimientos");

                entity.ToTable("Articulos_movimientos_tipos", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_objetivos>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Ejercicio })
                    .HasName("PK_Articulos_objetivos");

                entity.ToTable("Articulos_objetivos", "Ventas");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Objetivo_exportacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_media_exportacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_media_nacional)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_nacional)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_real_exportacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_real_nacional)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_objetivo_exportacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_objetivo_nacional)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_objetivos)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_objetivos_Articulos");
            });

            modelBuilder.Entity<Articulos_piecerio_subcontratado>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_piecerio_subcontratado");

                entity.ToTable("Articulos_piecerio_subcontratado", "Carroceria");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Fase).HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasMaxLength(500);

                entity.Property(e => e.Operaciones_auxiliares).HasColumnType("nchar(3)");

                entity.Property(e => e.Prensa).HasColumnType("nchar(5)");

                entity.Property(e => e.Troquel).HasColumnType("nchar(20)");

                entity.Property(e => e.Unidades_hora).HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_piecerio_subcontratado)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_piecerio_subcontratado_Articulos");

                entity.HasOne(d => d.Operaciones_auxiliaresNavigation)
                    .WithMany(p => p.Articulos_piecerio_subcontratado)
                    .HasForeignKey(d => d.Operaciones_auxiliares)
                    .HasConstraintName("FK_Articulos_piecerio_subcontratado_Operaciones_auxiliares");
            });

            modelBuilder.Entity<Articulos_piezas_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Tipos_piezas");

                entity.ToTable("Articulos_piezas_tipos", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(50)");
            });

            modelBuilder.Entity<Articulos_recursos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_recursos");

                entity.ToTable("Articulos_recursos", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(1)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Articulos_referencias>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_referencia");

                entity.ToTable("Articulos_referencias", "Gestion");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_articulo");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(200)");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Referencia).HasColumnType("nchar(20)");
            });

            modelBuilder.Entity<Articulos_referencias_produccion>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Referencia_auxiliar })
                    .HasName("PK_Articulos_referencias");

                entity.ToTable("Articulos_referencias_produccion", "Carroceria");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_auxiliar).HasColumnType("nchar(20)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_referencias_produccion)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_referencias_produccion_Articulos");
            });

            modelBuilder.Entity<Articulos_reparto_costes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_configuracion_1");

                entity.ToTable("Articulos_reparto_costes", "Analitica");

                entity.Property(e => e.Area).HasColumnType("nchar(2)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(2)");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Seccion).HasColumnType("nchar(3)");

                entity.HasOne(d => d.AreaNavigation)
                    .WithMany(p => p.Articulos_reparto_costes)
                    .HasForeignKey(d => d.Area)
                    .HasConstraintName("FK_Articulos_configuracion_Areas_financieras");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_reparto_costes)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Articulos_configuracion_Articulos");

                entity.HasOne(d => d.Centro_costeNavigation)
                    .WithMany(p => p.Articulos_reparto_costes)
                    .HasForeignKey(d => d.Centro_coste)
                    .HasConstraintName("FK_Articulos_configuracion_Centros_coste_financieros");

                entity.HasOne(d => d.SeccionNavigation)
                    .WithMany(p => p.Articulos_reparto_costes)
                    .HasForeignKey(d => d.Seccion)
                    .HasConstraintName("FK_Articulos_configuracion_Secciones_contables");
            });

            modelBuilder.Entity<Articulos_stocks>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_stocks");

                entity.ToTable("Articulos_stocks", "Logistica");

                entity.HasIndex(e => e.Almacen)
                    .HasName("Idx_Almacen");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_Articulo");

                entity.HasIndex(e => e.Lote)
                    .HasName("Idx_Lote");

                entity.HasIndex(e => e.Ubicacion)
                    .HasName("Idx_Ubicacion");

                entity.HasIndex(e => new { e.Articulo, e.Almacen, e.Ubicacion, e.Lote })
                    .HasName("Idx_Agrupado")
                    .IsUnique();

                entity.Property(e => e.Almacen)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Existencias).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_ultimo_inventario).HasColumnType("smalldatetime");

                entity.Property(e => e.Lote).IsRequired();

                entity.Property(e => e.Reservado).HasDefaultValueSql("0");

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasColumnType("nchar(5)")
                    .HasDefaultValueSql("''");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_stocks)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_stocks_Articulos");

                entity.HasOne(d => d.Almacen_ubicaciones)
                    .WithMany(p => p.Articulos_stocks)
                    .HasForeignKey(d => new { d.Almacen, d.Ubicacion })
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_stocks_Almacen_ubicaciones");
            });

            modelBuilder.Entity<Articulos_stocks_auditacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Stock_auditacion");

                entity.ToTable("Articulos_stocks_auditacion", "Logistica");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Stock_fecha_maldivas)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Stock_fecha_real)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Articulos_stocks_auditacion_configuracion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_stocks_auditacion_configuracion");

                entity.ToTable("Articulos_stocks_auditacion_configuracion", "Logistica");

                entity.Property(e => e.Articulo_clasificacion).HasColumnType("nchar(2)");

                entity.Property(e => e.Auditar).HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Articulos_stocks_configuracion>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Almacen })
                    .HasName("PK_Articulos_stocks_configuracion");

                entity.ToTable("Articulos_stocks_configuracion", "Logistica");

                entity.HasIndex(e => e.Articulo_configuracion)
                    .HasName("Idx_ArticuloConfiguracion");

                entity.HasIndex(e => new { e.Existencias, e.Lanzamiento_pedido, e.Almacen, e.Articulo })
                    .HasName("_dta_index_Articulos_stocks_configuracion_11_1330637075__K2_K1_3_10");

                entity.HasIndex(e => new { e.Articulo, e.Almacen, e.Stock_minimo, e.Stock_seguridad, e.Lote_entrega, e.Punto_pedido })
                    .HasName("_dta_index_Articulos_stocks_configuracion_11_1330637075__K1_K2_K4_K5_K6_K7");

                entity.HasIndex(e => new { e.Lote_entrega, e.Punto_pedido, e.Stock_minimo, e.Stock_seguridad, e.Almacen, e.Articulo })
                    .HasName("_dta_index_Articulos_stocks_configuracion_11_1330637075__K2_K1_4_5_6_7");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo_configuracion).HasColumnType("nchar(20)");

                entity.Property(e => e.Existencias).HasDefaultValueSql("0");

                entity.Property(e => e.Lanzamiento_entrega).HasDefaultValueSql("0");

                entity.Property(e => e.Lanzamiento_pedido).HasDefaultValueSql("0");

                entity.Property(e => e.Lanzamiento_propuesta).HasDefaultValueSql("0");

                entity.Property(e => e.Lote_diferido).HasDefaultValueSql("0");

                entity.Property(e => e.Lote_entrega).HasDefaultValueSql("0");

                entity.Property(e => e.Punto_pedido).HasDefaultValueSql("0");

                entity.Property(e => e.Stock_minimo).HasDefaultValueSql("0");

                entity.Property(e => e.Stock_seguridad).HasDefaultValueSql("0");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Articulos_stocks_configuracion)
                    .HasForeignKey(d => d.Almacen)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_stocks_configuracion_Almacen");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_stocks_configuracion)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_stocks_configuracion_Articulos");
            });

            modelBuilder.Entity<Articulos_stocks_conjuntos>(entity =>
            {
                entity.HasKey(e => new { e.Padre, e.Articulo })
                    .HasName("PK_Articulos_stocks_conjuntos");

                entity.ToTable("Articulos_stocks_conjuntos", "Logistica");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_Articulo");

                entity.HasIndex(e => e.Padre)
                    .HasName("Idx_Padre");

                entity.Property(e => e.Padre).HasColumnType("nchar(20)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.HasOne(d => d.PadreNavigation)
                    .WithMany(p => p.Articulos_stocks_conjuntos)
                    .HasForeignKey(d => d.Padre)
                    .HasConstraintName("FK_Articulos_stocks_conjuntos_Articulos");
            });

            modelBuilder.Entity<Articulos_tarifas>(entity =>
            {
                entity.HasKey(e => new { e.Tarifa, e.Articulo })
                    .HasName("PK_Articulos_tarifas");

                entity.ToTable("Articulos_tarifas", "Precios");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_articulo");

                entity.HasIndex(e => e.Divisa)
                    .HasName("Idx_divisa");

                entity.HasIndex(e => e.Fecha_final)
                    .HasName("Idx_fecha_final");

                entity.HasIndex(e => e.Fecha_inicio)
                    .HasName("Idx_fecha_inicio");

                entity.HasIndex(e => e.Tarifa)
                    .HasName("Idx_tarifa");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_final)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_tarifas)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_tarifas_Articulos");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Articulos_tarifas)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Articulos_tarifas_Interlocutores_precios_tipos");

                entity.HasOne(d => d.TarifaNavigation)
                    .WithMany(p => p.Articulos_tarifas)
                    .HasForeignKey(d => d.Tarifa)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Articulos_tarifas_Articulos_tarifas_tipos");
            });

            modelBuilder.Entity<Articulos_tarifas_copia>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tarifas_ultima");

                entity.ToTable("Articulos_tarifas_copia", "Precios");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_copia).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_final)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_tarifas_copia)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_tarifas_ultima_Articulos");

                entity.HasOne(d => d.OperacionNavigation)
                    .WithMany(p => p.Articulos_tarifas_copia)
                    .HasForeignKey(d => d.Operacion)
                    .HasConstraintName("FK_Articulos_tarifas_copia_Precios_copias");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Articulos_tarifas_copia)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Articulos_tarifas_ultima_Interlocutores_precios_tipos");
            });

            modelBuilder.Entity<Articulos_tarifas_historico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tarifas_historico");

                entity.ToTable("Articulos_tarifas_historico", "Precios");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_tarifas_historico)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_tarifas_historico_Articulos");
            });

            modelBuilder.Entity<Articulos_tarifas_temporal>(entity =>
            {
                entity.HasKey(e => new { e.Tarifa, e.Articulo, e.Fecha_inicio, e.Fecha_final })
                    .HasName("PK_Articulos_tarifas_temporal");

                entity.ToTable("Articulos_tarifas_temporal", "Precios");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Articulo");

                entity.HasIndex(e => e.Divisa)
                    .HasName("Idx_divisa");

                entity.HasIndex(e => e.Fecha_final)
                    .HasName("Idx_fecha_final");

                entity.HasIndex(e => e.Fecha_inicio)
                    .HasName("Idx_fecha_inicio");

                entity.HasIndex(e => e.Tarifa)
                    .HasName("Idx_tarifa");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Fecha_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Codigo).ValueGeneratedOnAdd();

                entity.Property(e => e.Descuento).HasColumnType("smallmoney");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Incremento_porcentual)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Incremento_total)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operacion_fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Precio_anterior).HasColumnType("money");

                entity.Property(e => e.Recargo).HasColumnType("smallmoney");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Articulos_tarifas_temporal)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Articulos_tarifas_temporal_Articulos");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Articulos_tarifas_temporal)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Articulos_tarifas_temporal_Interlocutores_precios_tipos");

                entity.HasOne(d => d.TarifaNavigation)
                    .WithMany(p => p.Articulos_tarifas_temporal)
                    .HasForeignKey(d => d.Tarifa)
                    .HasConstraintName("FK_Articulos_tarifas_temporal_Articulos_tarifas_tipos");
            });

            modelBuilder.Entity<Articulos_tarifas_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tarifas_tipos");

                entity.ToTable("Articulos_tarifas_tipos", "Precios");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Decimales).HasDefaultValueSql("2");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_tipos_calidad>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tipos_calidad");

                entity.ToTable("Articulos_tipos_calidad", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_tipos_competencia>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tipos_competencia");

                entity.ToTable("Articulos_tipos_competencia", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Articulos_tipos_materia_prima>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tipos_materia_prima");

                entity.ToTable("Articulos_tipos_materia_prima", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_tipos_origen>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tipos_origen");

                entity.ToTable("Articulos_tipos_origen", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Articulos_tipos_produccion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tipos_produccion");

                entity.ToTable("Articulos_tipos_produccion", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_tipos_productos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tipos_productos");

                entity.ToTable("Articulos_tipos_productos", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_tipos_suministro>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tipos_suministro");

                entity.ToTable("Articulos_tipos_suministro", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Articulos_tipos_troquel>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_tipos_troquel");

                entity.ToTable("Articulos_tipos_troquel", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Articulos_traducciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_traducciones");

                entity.ToTable("Articulos_traducciones", "Gestion");

                entity.Property(e => e.Espanol).HasMaxLength(254);

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Referencia_auxiliar).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo_campo).HasMaxLength(50);

                entity.Property(e => e.Traduccion).HasMaxLength(254);
            });

            modelBuilder.Entity<Articulos_troqueles_costo_compra>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Identificacion })
                    .HasName("PK_Articulos_troqueles_costo_compra");

                entity.ToTable("Articulos_troqueles_costo_compra", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Identificacion).HasMaxLength(50);

                entity.Property(e => e.Coste).HasColumnType("money");

                entity.Property(e => e.Fecha_compra).HasColumnType("smalldatetime");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(10)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<Articulos_utiles>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_Maestro");

                entity.ToTable("Articulos_utiles", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("varchar(25)");

                entity.Property(e => e.Activo).HasDefaultValueSql("1");

                entity.Property(e => e.Almacen).HasColumnType("char(3)");

                entity.Property(e => e.Alto).HasDefaultValueSql("0");

                entity.Property(e => e.Ancho).HasDefaultValueSql("0");

                entity.Property(e => e.Color).HasColumnType("varchar(50)");

                entity.Property(e => e.Componente).HasColumnType("varchar(40)");

                entity.Property(e => e.Estado).HasColumnType("varchar(50)");

                entity.Property(e => e.Fecha_edicion).HasColumnType("smalldatetime");

                entity.Property(e => e.Funcion).HasColumnType("varchar(30)");

                entity.Property(e => e.Largo).HasDefaultValueSql("0");

                entity.Property(e => e.Mano).HasColumnType("varchar(50)");

                entity.Property(e => e.Marca_vehiculo).HasColumnType("varchar(25)");

                entity.Property(e => e.Modelo_vehiculo).HasColumnType("varchar(30)");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Orden_trabajo).HasColumnType("varchar(50)");

                entity.Property(e => e.Origen).HasColumnType("varchar(50)");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_base_inferior).HasDefaultValueSql("0");

                entity.Property(e => e.Peso_base_superior).HasDefaultValueSql("0");

                entity.Property(e => e.Pieza).HasColumnType("varchar(30)");

                entity.Property(e => e.Propiedad).HasColumnType("varchar(50)");

                entity.Property(e => e.Ubicacion).HasColumnType("varchar(50)");

                entity.Property(e => e.Zona).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Bancos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Empresas_bancos_1");

                entity.ToTable("Bancos", "Financiera");

                entity.HasIndex(e => new { e.Entidad, e.Agencia })
                    .HasName("EntidadAgenciaIdx")
                    .IsUnique();

                entity.Property(e => e.Codigo).HasColumnType("nchar(4)");

                entity.Property(e => e.Agencia)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.CPais).HasColumnType("nchar(3)");

                entity.Property(e => e.CPostal).HasColumnType("nchar(10)");

                entity.Property(e => e.Clave1).HasColumnType("nchar(20)");

                entity.Property(e => e.Clave2).HasColumnType("nchar(20)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Comision)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comision_minima)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Contacto).HasMaxLength(50);

                entity.Property(e => e.Contrato).HasColumnType("nchar(11)");

                entity.Property(e => e.Direccion).HasMaxLength(100);

                entity.Property(e => e.Director).HasMaxLength(50);

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Entidad)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Extranjeros).HasMaxLength(50);

                entity.Property(e => e.Fax1).HasMaxLength(50);

                entity.Property(e => e.Fax2).HasMaxLength(50);

                entity.Property(e => e.Forfait)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ftp).HasMaxLength(40);

                entity.Property(e => e.Gastos_correo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gastos_correo_devolucion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gastos_devolucion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Grafico).HasMaxLength(50);

                entity.Property(e => e.Horario_oficina_desde).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina_hasta).HasColumnType("nchar(5)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Internet).HasMaxLength(40);

                entity.Property(e => e.Movil).HasMaxLength(50);

                entity.Property(e => e.Nif).HasColumnType("nchar(12)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Remesa).HasDefaultValueSql("0");

                entity.Property(e => e.Sufijo).HasColumnType("nchar(3)");

                entity.Property(e => e.Telefono1).HasMaxLength(50);

                entity.Property(e => e.Telefono2).HasMaxLength(50);

                entity.Property(e => e.Timbrado).HasDefaultValueSql("0");

                entity.Property(e => e.VoIp1).HasMaxLength(50);

                entity.Property(e => e.VoIp2).HasMaxLength(50);
            });

            modelBuilder.Entity<Bancos_cuentas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Empresas_bancos_cuentas");

                entity.ToTable("Bancos_cuentas", "Financiera");

                entity.Property(e => e.Activada).HasDefaultValueSql("1");

                entity.Property(e => e.Cuenta).HasColumnType("nchar(10)");

                entity.Property(e => e.Dc).HasColumnType("nchar(2)");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Entidad)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Iban).HasColumnType("nchar(34)");

                entity.Property(e => e.Interes)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Swift).HasColumnType("nchar(11)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(2)");

                entity.HasOne(d => d.EntidadNavigation)
                    .WithMany(p => p.Bancos_cuentas)
                    .HasForeignKey(d => d.Entidad)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Bancos_cuentas_Bancos");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Bancos_cuentas)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("FK_Bancos_cuentas_Interlocutores_cuentas_bancarias_tipos");
            });

            modelBuilder.Entity<Bancos_cuentas_conceptos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Cuentas_conceptos_1");

                entity.ToTable("Bancos_cuentas_conceptos", "Financiera");

                entity.Property(e => e.Concepto)
                    .IsRequired()
                    .HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Bancos_cuentas_configuracion>(entity =>
            {
                entity.HasKey(e => new { e.Cuenta, e.Concepto })
                    .HasName("PK_Cuentas_conceptos");

                entity.ToTable("Bancos_cuentas_configuracion", "Financiera");

                entity.Property(e => e.Cuenta).HasColumnType("nchar(10)");

                entity.Property(e => e.Valor_monetario)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Valor_porcentual)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ConceptoNavigation)
                    .WithMany(p => p.Bancos_cuentas_configuracion)
                    .HasForeignKey(d => d.Concepto)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Cuentas_configuracion_Cuentas_conceptos");
            });

            modelBuilder.Entity<Bancos_cuentas_divisas_apuntes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Bancos_cuentas_divisas_apuntes");

                entity.ToTable("Bancos_cuentas_divisas_apuntes", "Financiera");

                entity.Property(e => e.Cuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Debe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Haber)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Saldo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CuentaNavigation)
                    .WithMany(p => p.Bancos_cuentas_divisas_apuntes)
                    .HasForeignKey(d => d.Cuenta)
                    .HasConstraintName("FK_Bancos_cuentas_divisas_apuntes_Bancos_cuentas_divisas_tipos");
            });

            modelBuilder.Entity<Bancos_cuentas_divisas_tipos>(entity =>
            {
                entity.HasKey(e => e.Cuenta)
                    .HasName("PK_Bancos_cuentas_divisas");

                entity.ToTable("Bancos_cuentas_divisas_tipos", "Financiera");

                entity.Property(e => e.Cuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");
            });

            modelBuilder.Entity<Bancos_cuentas_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_bancos_tipos");

                entity.ToTable("Bancos_cuentas_tipos", "Financiera");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Calendarios>(entity =>
            {
                entity.HasKey(e => e.Calendario)
                    .HasName("PK_Calendarios");

                entity.ToTable("Calendarios", "General");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");
            });

            modelBuilder.Entity<Calendarios_configuracion>(entity =>
            {
                entity.HasKey(e => new { e.Calendario, e.Fecha })
                    .HasName("PK_Calendarios_configuracion");

                entity.ToTable("Calendarios_configuracion", "General");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Tipo).HasColumnType("nchar(2)");

                entity.HasOne(d => d.CalendarioNavigation)
                    .WithMany(p => p.Calendarios_configuracion)
                    .HasForeignKey(d => d.Calendario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Calendarios_configuracion_Calendarios");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Calendarios_configuracion)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("FK_Calendarios_configuracion_Calendarios_tipos");
            });

            modelBuilder.Entity<Calendarios_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Calendarios_tipos");

                entity.ToTable("Calendarios_tipos", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Color).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(180);
            });

            modelBuilder.Entity<Cargas_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Cargas_tipos");

                entity.ToTable("Cargas_tipos", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Cartera_compras>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Compras_cartera");

                entity.ToTable("Cartera_compras", "Financiera");

                entity.HasIndex(e => e.Estado)
                    .HasName("Idx_Estado");

                entity.HasIndex(e => e.Factura)
                    .HasName("Idx_Factura");

                entity.HasIndex(e => e.Proveedor)
                    .HasName("Idx_proveedor");

                entity.HasIndex(e => e.Tipo)
                    .HasName("Idx_Tipo");

                entity.Property(e => e.Abono_recibo_importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Banco_pago_agencia).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_pago_cuenta).HasColumnType("nchar(10)");

                entity.Property(e => e.Banco_pago_dc).HasColumnType("nchar(2)");

                entity.Property(e => e.Banco_pago_entidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_pago_nombre).HasMaxLength(50);

                entity.Property(e => e.Banco_pago_subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Banco_receptor_agencia).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_receptor_cuenta).HasColumnType("nchar(10)");

                entity.Property(e => e.Banco_receptor_dc).HasColumnType("nchar(2)");

                entity.Property(e => e.Banco_receptor_entidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_receptor_nombre).HasMaxLength(50);

                entity.Property(e => e.Banco_receptor_subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Bolsa).HasDefaultValueSql("0");

                entity.Property(e => e.Comision_bancaria)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Diferencia_cambio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_base).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Divisa_cambio_pago)
                    .HasColumnType("money")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Estado)
                    .HasColumnType("nchar(10)")
                    .HasDefaultValueSql("'Normal'");

                entity.Property(e => e.Factura_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Factura_ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Factura_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Factura_modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Fecha_cancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_cobro).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_devolucion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_orden_pago).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_vencimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Gastos_devolucion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Generar_asiento).HasDefaultValueSql("1");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Importe_caracter).HasMaxLength(200);

                entity.Property(e => e.Observaciones).HasMaxLength(1000);

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Recibo).HasDefaultValueSql("1");

                entity.Property(e => e.Referencia).HasColumnType("nchar(20)");

                entity.Property(e => e.Remesa_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Remesa_ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Remesa_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Remesa_modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Subcuenta_compras).HasColumnType("nchar(20)");

                entity.Property(e => e.Subcuenta_gastos).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo).HasDefaultValueSql("1");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_divisa_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.FacturaNavigation)
                    .WithMany(p => p.Cartera_compras)
                    .HasForeignKey(d => d.Factura)
                    .HasConstraintName("FK_Cartera_compras_Facturas_cabecera");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Cartera_compras)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Cartera_compras_Proveedores");
            });

            modelBuilder.Entity<Cartera_compras_historico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Compras_cartera_historico");

                entity.ToTable("Cartera_compras_historico", "Financiera");

                entity.Property(e => e.Bolsa).HasDefaultValueSql("0");

                entity.Property(e => e.Comision_bancaria)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_cambio_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_cambio_pago)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Estado).HasColumnType("nchar(10)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Gastos_devolucion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gastos_reclamacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibo).HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ReciboNavigation)
                    .WithMany(p => p.Cartera_compras_historico)
                    .HasForeignKey(d => d.Recibo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Compras_cartera_historico_Compras_cartera");
            });

            modelBuilder.Entity<Cartera_configuracion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Cartera_configuracion");

                entity.ToTable("Cartera_configuracion", "Financiera");

                entity.Property(e => e.Codigo).ValueGeneratedNever();
            });

            modelBuilder.Entity<Cartera_estados>(entity =>
            {
                entity.HasKey(e => new { e.Codigo, e.Estado })
                    .HasName("PK_Cartera_estados");

                entity.ToTable("Cartera_estados", "Financiera");

                entity.Property(e => e.Codigo).ValueGeneratedOnAdd();

                entity.Property(e => e.Estado).HasColumnType("nchar(10)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(1000);

                entity.Property(e => e.Tipo).HasDefaultValueSql("3");
            });

            modelBuilder.Entity<Cartera_ventas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_cartera");

                entity.ToTable("Cartera_ventas", "Financiera");

                entity.HasIndex(e => e.Cliente)
                    .HasName("Idx_cliente");

                entity.HasIndex(e => e.Estado)
                    .HasName("Idx_Estado");

                entity.HasIndex(e => e.Factura)
                    .HasName("Idx_Factura");

                entity.HasIndex(e => e.Tipo)
                    .HasName("Idx_Tipo");

                entity.Property(e => e.Abono_recibo_importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Banco_cobro_agencia).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_cobro_cuenta).HasColumnType("nchar(10)");

                entity.Property(e => e.Banco_cobro_dc).HasColumnType("nchar(2)");

                entity.Property(e => e.Banco_cobro_entidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_cobro_nombre).HasMaxLength(50);

                entity.Property(e => e.Banco_cobro_subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Banco_receptor_agencia).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_receptor_cuenta).HasColumnType("nchar(10)");

                entity.Property(e => e.Banco_receptor_dc).HasColumnType("nchar(2)");

                entity.Property(e => e.Banco_receptor_entidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_receptor_nombre).HasMaxLength(50);

                entity.Property(e => e.Banco_receptor_subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Bolsa).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Comision_bancaria)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Diferencia_cambio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_base).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio_cobro)
                    .HasColumnType("money")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Divisa_cambio_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Estado).HasColumnType("nchar(10)");

                entity.Property(e => e.Factura_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Factura_ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Factura_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Factura_modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Fecha_cancelacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_cobro).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_devolucion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_orden_pago).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_recepcion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_vencimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Gastos_devolucion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gastos_reclamacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Generar_asiento).HasDefaultValueSql("1");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Importe_caracter).HasMaxLength(200);

                entity.Property(e => e.Notificado).HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasMaxLength(1000);

                entity.Property(e => e.Recibo).HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Remesa_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Remesa_ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Remesa_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Remesa_modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Serie)
                    .HasColumnType("nchar(1)")
                    .HasDefaultValueSql("'A'");

                entity.Property(e => e.Subcuenta_ventas).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo).HasDefaultValueSql("1");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_divisa_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.FacturaNavigation)
                    .WithMany(p => p.Cartera_ventas)
                    .HasForeignKey(d => d.Factura)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Cartera_ventas_Facturas_cabecera");
            });

            modelBuilder.Entity<Cartera_ventas_historico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_cartera_historico");

                entity.ToTable("Cartera_ventas_historico", "Financiera");

                entity.Property(e => e.Comision_bancaria)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_cambio_cobro)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_cambio_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Estado).HasColumnType("nchar(10)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Gastos_devolucion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Gastos_reclamacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ReciboNavigation)
                    .WithMany(p => p.Cartera_ventas_historico)
                    .HasForeignKey(d => d.Recibo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ventas_cartera_historico_Ventas_cartera");
            });

            modelBuilder.Entity<Centros_coste_financieros>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_centros_coste");

                entity.ToTable("Centros_coste_financieros", "Analitica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Tipo).HasMaxLength(50);
            });

            modelBuilder.Entity<Centros_costes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK___3__10");

                entity.ToTable("Centros_costes", "Produccion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Codigo_captor).HasColumnType("nchar(3)");

                entity.Property(e => e.Coste_centro)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_hora_maquina)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_hora_modificar)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Habil_operacion).HasColumnType("nchar(8)");

                entity.Property(e => e.Habil_preparacion).HasColumnType("nchar(8)");

                entity.Property(e => e.Horas_disponibles_dia).HasDefaultValueSql("0");

                entity.Property(e => e.Nemonico).HasColumnType("nchar(30)");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Seccion).HasColumnType("nchar(10)");

                entity.Property(e => e.Tiempo_trasferencia).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Centros_costes_grupos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Centros_coste_grupos");

                entity.ToTable("Centros_costes_grupos", "Produccion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Centros_costes_grupos)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Centros_costes_grupos_Almacen");
            });

            modelBuilder.Entity<Centros_costes_grupos_relacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Centros_coste_grupos_relacion");

                entity.ToTable("Centros_costes_grupos_relacion", "Produccion");

                entity.Property(e => e.Centro).HasColumnType("nchar(6)");

                entity.Property(e => e.Grupo).HasColumnType("nchar(3)");

                entity.Property(e => e.Interna).HasDefaultValueSql("1");

                entity.HasOne(d => d.CentroNavigation)
                    .WithMany(p => p.Centros_costes_grupos_relacion)
                    .HasForeignKey(d => d.Centro)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Centros_coste_grupos_relacion_Centros_costes");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Centros_costes_grupos_relacion)
                    .HasForeignKey(d => d.Grupo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Centros_coste_grupos_relacion_Centros_coste_grupos");
            });

            modelBuilder.Entity<Centros_costes_maquinas>(entity =>
            {
                entity.HasKey(e => new { e.Centro, e.Maquina })
                    .HasName("PK_Centros_costes_maquinas");

                entity.ToTable("Centros_costes_maquinas", "Produccion");

                entity.Property(e => e.Centro).HasColumnType("nchar(6)");

                entity.Property(e => e.Maquina).HasColumnType("nchar(5)");

                entity.HasOne(d => d.CentroNavigation)
                    .WithMany(p => p.Centros_costes_maquinas)
                    .HasForeignKey(d => d.Centro)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Centros_costes_maquinas_Centros_costes");
            });

            modelBuilder.Entity<Centros_trabajo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Centros");

                entity.ToTable("Centros_trabajo", "Produccion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Capacidad_diaria).HasDefaultValueSql("288000000");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Tipo).HasColumnType("nchar(3)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Centros_trabajo)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Centros_Almacen");
            });

            modelBuilder.Entity<Centros_trabajo_grupos>(entity =>
            {
                entity.HasKey(e => e.Grupo)
                    .HasName("PK_Centros_trabajo_grupos");

                entity.ToTable("Centros_trabajo_grupos", "Produccion");

                entity.Property(e => e.Grupo).HasColumnType("nchar(6)");

                entity.Property(e => e.Activo).HasDefaultValueSql("1");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Padre).HasColumnType("nchar(6)");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(15)");

                entity.HasOne(d => d.PadreNavigation)
                    .WithMany(p => p.InversePadreNavigation)
                    .HasForeignKey(d => d.Padre)
                    .HasConstraintName("FK_Centros_trabajo_grupos_Centros_trabajo_grupos");
            });

            modelBuilder.Entity<Centros_trabajo_grupos_relacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Centros_trabajo_grupos_relacion");

                entity.ToTable("Centros_trabajo_grupos_relacion", "Produccion");

                entity.Property(e => e.Centro_trabajo)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Grupo_trabajo)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.HasOne(d => d.Centro_trabajoNavigation)
                    .WithMany(p => p.Centros_trabajo_grupos_relacion)
                    .HasForeignKey(d => d.Centro_trabajo)
                    .HasConstraintName("FK_Centros_trabajo_grupos_relacion_Centros_trabajo");

                entity.HasOne(d => d.Grupo_trabajoNavigation)
                    .WithMany(p => p.Centros_trabajo_grupos_relacion)
                    .HasForeignKey(d => d.Grupo_trabajo)
                    .HasConstraintName("FK_Centros_trabajo_grupos_relacion_Centros_trabajo_grupos");
            });

            modelBuilder.Entity<Centros_trabajo_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Centros_trabajo_tipos");

                entity.ToTable("Centros_trabajo_tipos", "Produccion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Certificaciones_producto>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Certificaciones_producto");

                entity.ToTable("Certificaciones_producto", "Calidad");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");
            });

            modelBuilder.Entity<Certificaciones_sistema>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_tipos_certificacion");

                entity.ToTable("Certificaciones_sistema", "Calidad");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Clientes");

                entity.ToTable("Clientes", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Accion_ruptura_riesgo).HasDefaultValueSql("2");

                entity.Property(e => e.Agencia1).HasColumnType("nchar(6)");

                entity.Property(e => e.Agencia2).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente_aduanas_1).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente_aduanas_2).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Ajuste_vencimientos).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_informacion).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_operaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Carencia).HasDefaultValueSql("0");

                entity.Property(e => e.Clave1).HasMaxLength(20);

                entity.Property(e => e.Clave2).HasMaxLength(20);

                entity.Property(e => e.Clave3).HasMaxLength(20);

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo_credito_caucion).HasColumnType("nchar(10)");

                entity.Property(e => e.Comision)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Decimales_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_precios).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_totales).HasDefaultValueSql("2");

                entity.Property(e => e.Descuento_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_linea_detalle)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_pronto_pago)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_volumen)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dia_1_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_2_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_3_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Divisa)
                    .HasColumnType("nchar(3)")
                    .HasDefaultValueSql("'EUR'");

                entity.Property(e => e.Documentacion).HasColumnType("nchar(4)");

                entity.Property(e => e.Documentacion_enviar).HasDefaultValueSql("0");

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Experimentales).HasDefaultValueSql("0");

                entity.Property(e => e.Exportacion).HasDefaultValueSql("0");

                entity.Property(e => e.Factor_impresion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Facturacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Facturacion_cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Fecha_alta)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Ftp).HasMaxLength(100);

                entity.Property(e => e.Grafico).HasMaxLength(50);

                entity.Property(e => e.Grupo_compras).HasColumnType("nchar(5)");

                entity.Property(e => e.Grupo_sinonimos).HasColumnType("nchar(6)");

                entity.Property(e => e.Grupo_tarifa).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_descarga1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_descarga2).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina2).HasColumnType("nchar(5)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Incoterm1).HasColumnType("nchar(5)");

                entity.Property(e => e.Incoterm2).HasColumnType("nchar(5)");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Internet_acceso).HasDefaultValueSql("0");

                entity.Property(e => e.Internet_grupo).HasColumnType("nchar(5)");

                entity.Property(e => e.Intrastat).HasDefaultValueSql("0");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Numero).HasDefaultValueSql("0");

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Portes_descuento_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_trayecto).HasColumnType("nchar(2)");

                entity.Property(e => e.Portes_trayecto_coste)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Potencial).HasDefaultValueSql("0");

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Rappel_grupo).HasColumnType("nchar(4)");

                entity.Property(e => e.Rappel_tipo).HasColumnType("nchar(1)");

                entity.Property(e => e.Recargo_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_financiero)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Referencia_canarias).HasMaxLength(20);

                entity.Property(e => e.Restos).HasDefaultValueSql("0");

                entity.Property(e => e.Retencion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Riesgo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Riesgo_actual)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Riesgo_credito_caucion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ruta).HasColumnType("nchar(5)");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Tarifa).HasDefaultValueSql("0");

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Telefono3).HasMaxLength(30);

                entity.Property(e => e.Tipo_albaran).HasColumnType("nchar(12)");

                entity.Property(e => e.Tipo_factura).HasColumnType("nchar(12)");

                entity.Property(e => e.Tipo_operacion).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_recibo).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_registro).HasColumnType("nchar(10)");

                entity.Property(e => e.Tipo_venta).HasColumnType("nchar(12)");

                entity.Property(e => e.Transportista1).HasColumnType("nchar(6)");

                entity.Property(e => e.Transportista2).HasColumnType("nchar(6)");

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Vacaciones_final).HasColumnType("nchar(5)");

                entity.Property(e => e.Vacaciones_inicio).HasColumnType("nchar(5)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);

                entity.Property(e => e.Zona).HasColumnType("nchar(5)");

                entity.HasOne(d => d.DocumentacionNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Documentacion)
                    .HasConstraintName("FK_Clientes_Documentacion");

                entity.HasOne(d => d.Grupo_comprasNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Grupo_compras)
                    .HasConstraintName("FK_Clientes_Clientes_grupos_compras");

                entity.HasOne(d => d.TarifaNavigation)
                    .WithMany(p => p.Clientes)
                    .HasForeignKey(d => d.Tarifa)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Clientes_Articulos_tarifas_tipos");
            });

            modelBuilder.Entity<Clientes_anticipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Clientes_anticipos");

                entity.ToTable("Clientes_anticipos", "Gestion");

                entity.Property(e => e.Banco_cobro_subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Diferencia_cambio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio_anticipo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Divisa_cambio_cobro)
                    .HasColumnType("money")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnType("nchar(10)")
                    .HasDefaultValueSql("N'Normal'");

                entity.Property(e => e.Factura_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Factura_ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Factura_modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_anticipos)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_anticipos_Clientes");
            });

            modelBuilder.Entity<Clientes_articulos_bloqueados>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Articulo })
                    .HasName("PK_Interlocutores_articulos_bloqueados");

                entity.ToTable("Clientes_articulos_bloqueados", "Gestion");

                entity.HasIndex(e => e.Codaux)
                    .HasName("IX_Clientes_articulos_bloqueados");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_articulos_bloqueados)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Interlocutores_articulos_bloqueados_Articulos");
            });

            modelBuilder.Entity<Clientes_articulos_certificados>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Articulo })
                    .HasName("PK_Interlocutores_articulos_certificados");

                entity.ToTable("Clientes_articulos_certificados", "Gestion");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Certificacion).HasColumnType("nchar(2)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_articulos_certificados)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Clientes_articulos_certificados_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_articulos_certificados)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_articulos_certificados_Clientes");
            });

            modelBuilder.Entity<Clientes_bancos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Clientes_bancos");

                entity.ToTable("Clientes_bancos", "Gestion");

                entity.Property(e => e.Agencia).HasColumnType("nchar(4)");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Cuenta).HasMaxLength(10);

                entity.Property(e => e.Dc).HasColumnType("nchar(2)");

                entity.Property(e => e.Entidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Iban).HasColumnType("nchar(34)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Sufijo).HasColumnType("nchar(10)");

                entity.Property(e => e.Swift).HasColumnType("nchar(11)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(2)");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_bancos)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Clientes_bancos_Clientes");
            });

            modelBuilder.Entity<Clientes_cuentas_contables>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Tipo })
                    .HasName("PK_Clientes_cuentas_contables");

                entity.ToTable("Clientes_cuentas_contables", "Gestion");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(2)");

                entity.Property(e => e.Cuenta).HasColumnType("nchar(20)");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_cuentas_contables)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_cuentas_contables_Clientes");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Clientes_cuentas_contables)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Clientes_cuentas_contables_Cuentas_contables_tipos");
            });

            modelBuilder.Entity<Clientes_departamentos>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Tipo_departamento })
                    .HasName("PK_Clientes_departamentos");

                entity.ToTable("Clientes_departamentos", "Gestion");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo_departamento).HasColumnType("nchar(2)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Persona_contacto).HasMaxLength(50);

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_departamentos)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Clientes_departamentos_Clientes");

                entity.HasOne(d => d.Tipo_departamentoNavigation)
                    .WithMany(p => p.Clientes_departamentos)
                    .HasForeignKey(d => d.Tipo_departamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Clientes_departamentos_Departamentos_tipos");
            });

            modelBuilder.Entity<Clientes_direcciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Clientes_direcciones");

                entity.ToTable("Clientes_direcciones", "Gestion");

                entity.Property(e => e.Acceso_global).HasDefaultValueSql("0");

                entity.Property(e => e.Clave1).HasMaxLength(50);

                entity.Property(e => e.Clave2).HasMaxLength(50);

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Email3).HasMaxLength(100);

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Razon_social).HasMaxLength(200);

                entity.Property(e => e.Ruta).HasColumnType("nchar(5)");

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Tipo)
                    .HasColumnType("nchar(2)")
                    .HasDefaultValueSql("'01'");

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_direcciones)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Clientes_direcciones_Clientes1");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Clientes_direcciones)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("FK_Clientes_direcciones_Direcciones_tipos");
            });

            modelBuilder.Entity<Clientes_direcciones_tipos>(entity =>
            {
                entity.HasKey(e => new { e.Direccion, e.Tipo })
                    .HasName("PK_Clientes_direcciones_tipos");

                entity.ToTable("Clientes_direcciones_tipos", "Gestion");

                entity.Property(e => e.Tipo).HasColumnType("nchar(2)");
            });

            modelBuilder.Entity<Clientes_embalajes_configuracion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Clientes_embalajes_configuracion");

                entity.ToTable("Clientes_embalajes_configuracion", "Gestion");

                entity.Property(e => e.Altura_palet)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Certificada).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Desactivo).HasDefaultValueSql("0");

                entity.Property(e => e.Embalaje).HasColumnType("nchar(3)");

                entity.Property(e => e.ExtraUE).HasDefaultValueSql("0");

                entity.Property(e => e.Marca).HasColumnType("nchar(2)");

                entity.Property(e => e.Material_frances).HasDefaultValueSql("0");

                entity.Property(e => e.Material_no_frances).HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_porcentaje).HasColumnType("decimal");

                entity.Property(e => e.Tipo_pieza).HasColumnType("nchar(3)");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_embalajes_configuracion)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_embalajes_configuracion_Clientes");

                entity.HasOne(d => d.EmbalajeNavigation)
                    .WithMany(p => p.Clientes_embalajes_configuracion)
                    .HasForeignKey(d => d.Embalaje)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Interlocutores_embalajes_configuracion_Embalajes");
            });

            modelBuilder.Entity<Clientes_graficos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Clientes_graficos");

                entity.ToTable("Clientes_graficos", "Gestion");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_graficos)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Clientes_graficos_Clientes");
            });

            modelBuilder.Entity<Clientes_grupos_compras>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_grupos_compras");

                entity.ToTable("Clientes_grupos_compras", "Precios");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Clientes_grupos_compras_rappels>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_grupos_compras_rappels");

                entity.ToTable("Clientes_grupos_compras_rappels", "Precios");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_fin).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Grupo_compra)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.Objetivo_fin)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_inicio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rappel)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Grupo_compraNavigation)
                    .WithMany(p => p.Clientes_grupos_compras_rappels)
                    .HasForeignKey(d => d.Grupo_compra)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Interlocutores_grupos_compras_rappels_Interlocutores_grupos_compras");
            });

            modelBuilder.Entity<Clientes_grupos_tarifas>(entity =>
            {
                entity.HasKey(e => new { e.Grupo, e.Articulo })
                    .HasName("PK_Interlocutores_grupos_tarifas");

                entity.ToTable("Clientes_grupos_tarifas", "Precios");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_articulo");

                entity.HasIndex(e => e.Divisa)
                    .HasName("Idx_divisa");

                entity.HasIndex(e => e.Fecha_final)
                    .HasName("Idx_fecha_final");

                entity.HasIndex(e => e.Fecha_inicio)
                    .HasName("Idx_fecha_inicio");

                entity.HasIndex(e => e.Grupo)
                    .HasName("Idx_grupo");

                entity.Property(e => e.Grupo).HasColumnType("nchar(5)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_final)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Interlocutores_grupos_tarifas_Articulos");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas)
                    .HasForeignKey(d => d.Grupo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Interlocutores_grupos_tarifas_Interlocutores_grupos_tarifas_tipos");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Interlocutores_grupos_tarifas_Interlocutores_precios_tipos");
            });

            modelBuilder.Entity<Clientes_grupos_tarifas_copia>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_grupos_tarifas_ultima");

                entity.ToTable("Clientes_grupos_tarifas_copia", "Precios");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_copia).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_final)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Grupo)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas_copia)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Interlocutores_grupos_tarifas_ultima_Articulos");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas_copia)
                    .HasForeignKey(d => d.Grupo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Interlocutores_grupos_tarifas_ultima_Interlocutores_grupos_tarifas_tipos");

                entity.HasOne(d => d.OperacionNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas_copia)
                    .HasForeignKey(d => d.Operacion)
                    .HasConstraintName("FK_Clientes_grupos_tarifas_copia_Precios_copias");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas_copia)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Interlocutores_grupos_tarifas_ultima_Interlocutores_precios_tipos");
            });

            modelBuilder.Entity<Clientes_grupos_tarifas_historico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_grupos_tarifas_historico");

                entity.ToTable("Clientes_grupos_tarifas_historico", "Precios");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Grupo)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas_historico)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Interlocutores_grupos_tarifas_historico_Articulos");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas_historico)
                    .HasForeignKey(d => d.Grupo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Clientes_grupos_tarifas_historico_Clientes_grupos_tarifas_tipos");
            });

            modelBuilder.Entity<Clientes_grupos_tarifas_temporal>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_grupos_tarifas_temporal");

                entity.ToTable("Clientes_grupos_tarifas_temporal", "Precios");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_articulo");

                entity.HasIndex(e => e.Divisa)
                    .HasName("Idx_divisa");

                entity.HasIndex(e => e.Fecha_final)
                    .HasName("Idx_fecha_final");

                entity.HasIndex(e => e.Fecha_inicio)
                    .HasName("Idx_fecha_inicio");

                entity.HasIndex(e => e.Grupo)
                    .HasName("Idx_grupo");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Grupo)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.Incremento_porcentual)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Incremento_total)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operacion_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas_temporal)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Interlocutores_grupos_tarifas_temporal_Articulos");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas_temporal)
                    .HasForeignKey(d => d.Grupo)
                    .HasConstraintName("FK_Interlocutores_grupos_tarifas_temporal_Interlocutores_grupos_tarifas_tipos");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Clientes_grupos_tarifas_temporal)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Interlocutores_grupos_tarifas_temporal_Interlocutores_precios_tipos");
            });

            modelBuilder.Entity<Clientes_grupos_tarifas_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_grupos");

                entity.ToTable("Clientes_grupos_tarifas_tipos", "Precios");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Comision)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Clientes_internet_accesos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_internet_accesos");

                entity.ToTable("Clientes_internet_accesos", "Internet");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Direccion_ip).HasMaxLength(20);

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Expiracion).HasColumnType("datetime");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Proceso).HasMaxLength(240);

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_internet_accesos)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Clientes_internet_accesos_Clientes");
            });

            modelBuilder.Entity<Clientes_internet_grupos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_internet_grupos");

                entity.ToTable("Clientes_internet_grupos", "Internet");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Clientes_internet_seguridad>(entity =>
            {
                entity.HasKey(e => e.Clave)
                    .HasName("PK_Interlocutores_internet_seguridad");

                entity.ToTable("Clientes_internet_seguridad", "Internet");

                entity.Property(e => e.Clave).ValueGeneratedNever();

                entity.Property(e => e.Acceso).HasDefaultValueSql("0");

                entity.Property(e => e.Contenido).HasMaxLength(100);

                entity.Property(e => e.Imagen).HasDefaultValueSql("0");

                entity.Property(e => e.Variable).HasMaxLength(50);
            });

            modelBuilder.Entity<Clientes_internet_seguridad_claves>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_internet_seguridad_claves");

                entity.ToTable("Clientes_internet_seguridad_claves", "Internet");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Grupo).HasColumnType("nchar(5)");

                entity.HasOne(d => d.ClaveNavigation)
                    .WithMany(p => p.Clientes_internet_seguridad_claves)
                    .HasForeignKey(d => d.Clave)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Interlocutores_internet_seguridad_claves_Interlocutores_internet_seguridad");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_internet_seguridad_claves)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Clientes_internet_seguridad_claves_Clientes");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Clientes_internet_seguridad_claves)
                    .HasForeignKey(d => d.Grupo)
                    .HasConstraintName("FK_Interlocutores_internet_seguridad_claves_Interlocutores_internet_grupos");
            });

            modelBuilder.Entity<Clientes_objetivos>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Ejercicio })
                    .HasName("PK_Interlocutores_objetivos");

                entity.ToTable("Clientes_objetivos", "Ventas");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Objetivo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Prevision)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_objetivos)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Clientes_objetivos_Clientes");
            });

            modelBuilder.Entity<Clientes_precios_especiales>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Cliente })
                    .HasName("PK_Interlocutores_precios_especiales");

                entity.ToTable("Clientes_precios_especiales", "Precios");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_articulo");

                entity.HasIndex(e => e.Cliente)
                    .HasName("Idx_cliente");

                entity.HasIndex(e => e.Divisa)
                    .HasName("Idx_divisa");

                entity.HasIndex(e => e.Fecha_final)
                    .HasName("Idx_fecha_final");

                entity.HasIndex(e => e.Fecha_inicio)
                    .HasName("Idx_fecha_inicio");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_final)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_precios_especiales)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_precios_especiales)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_precios_especiales_Clientes");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Clientes_precios_especiales)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_Interlocutores_precios_tipos");
            });

            modelBuilder.Entity<Clientes_precios_especiales_cantidad>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Articulo, e.Cantidad_inicial, e.Cantidad_final })
                    .HasName("PK_Interlocutores_precios_especiales_cantidad");

                entity.ToTable("Clientes_precios_especiales_cantidad", "Precios");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_articulo");

                entity.HasIndex(e => e.Cantidad_final)
                    .HasName("Idx_cantidad_final");

                entity.HasIndex(e => e.Cantidad_inicial)
                    .HasName("Idx_cantidad_inicial");

                entity.HasIndex(e => e.Cliente)
                    .HasName("Idx_interlocutor");

                entity.HasIndex(e => e.Divisa)
                    .HasName("Idx_divisa");

                entity.HasIndex(e => e.Fecha_final)
                    .HasName("Idx_fecha_final");

                entity.HasIndex(e => e.Fecha_inicio)
                    .HasName("Idx_fecha_inicio");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad_inicial).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_final).HasDefaultValueSql("0");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_final)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_cantidad_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_precios_especiales_cantidad_Clientes");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_cantidad_Interlocutores_precios_tipos");
            });

            modelBuilder.Entity<Clientes_precios_especiales_cantidad_copia>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_precios_especiales_cantidad_ultima");

                entity.ToTable("Clientes_precios_especiales_cantidad_copia", "Precios");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad_final).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_inicial).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_copia).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_final)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad_copia)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_cantidad_ultima_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad_copia)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_precios_especiales_cantidad_copia_Clientes");

                entity.HasOne(d => d.OperacionNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad_copia)
                    .HasForeignKey(d => d.Operacion)
                    .HasConstraintName("FK_Clientes_precios_especiales_cantidad_copia_Precios_copias");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad_copia)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_cantidad_ultima_Interlocutores_precios_tipos");
            });

            modelBuilder.Entity<Clientes_precios_especiales_cantidad_historico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_precios_especiales_cantidad_historico");

                entity.ToTable("Clientes_precios_especiales_cantidad_historico", "Precios");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad_final).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_inicial).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad_historico)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_cantidad_historico_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad_historico)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_precios_especiales_cantidad_historico_Clientes");
            });

            modelBuilder.Entity<Clientes_precios_especiales_cantidad_temporal>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Articulo, e.Cantidad_inicial, e.Cantidad_final, e.Fecha_inicio, e.Fecha_final })
                    .HasName("PK_Interlocutores_precios_especiales_cantidad_temporal");

                entity.ToTable("Clientes_precios_especiales_cantidad_temporal", "Precios");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_articulo");

                entity.HasIndex(e => e.Cantidad_final)
                    .HasName("Idx_cantidad_final");

                entity.HasIndex(e => e.Cantidad_inicial)
                    .HasName("Idx_cantidad_inicial");

                entity.HasIndex(e => e.Cliente)
                    .HasName("Idx_cliente");

                entity.HasIndex(e => e.Divisa)
                    .HasName("Idx_divisa");

                entity.HasIndex(e => e.Fecha_final)
                    .HasName("Idx_fecha_final");

                entity.HasIndex(e => e.Fecha_inicio)
                    .HasName("Idx_fecha_inicio");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Fecha_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Codigo).ValueGeneratedOnAdd();

                entity.Property(e => e.Descuento).HasColumnType("smallmoney");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Incremento_porcentual)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Incremento_total)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operacion_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo).HasColumnType("smallmoney");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad_temporal)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_cantidad_temporal_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad_temporal)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_precios_especiales_cantidad_temporal_Clientes");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_cantidad_temporal)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_cantidad_temporal_Interlocutores_precios_tipos");
            });

            modelBuilder.Entity<Clientes_precios_especiales_copia>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_precios_especiales_ultima");

                entity.ToTable("Clientes_precios_especiales_copia", "Precios");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_copia).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_final)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_copia)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_ultima_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_copia)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_precios_especiales_copia_Clientes");

                entity.HasOne(d => d.OperacionNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_copia)
                    .HasForeignKey(d => d.Operacion)
                    .HasConstraintName("FK_Clientes_precios_especiales_copia_Precios_copias");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_copia)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_ultima_Interlocutores_precios_tipos");
            });

            modelBuilder.Entity<Clientes_precios_especiales_historico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_precios_especiales_historico");

                entity.ToTable("Clientes_precios_especiales_historico", "Precios");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Descuento).HasColumnType("smallmoney");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Precio_anterior).HasColumnType("money");

                entity.Property(e => e.Recargo).HasColumnType("smallmoney");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_historico)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_historico_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_historico)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_precios_especiales_historico_Clientes");
            });

            modelBuilder.Entity<Clientes_precios_especiales_temporal>(entity =>
            {
                entity.HasKey(e => new { e.Articulo, e.Cliente, e.Fecha_inicio, e.Fecha_final })
                    .HasName("PK_Interlocutores_precios_especiales_temporal");

                entity.ToTable("Clientes_precios_especiales_temporal", "Precios");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_articulo");

                entity.HasIndex(e => e.Cliente)
                    .HasName("Idx_cliente");

                entity.HasIndex(e => e.Divisa)
                    .HasName("Idx_divisa");

                entity.HasIndex(e => e.Fecha_final)
                    .HasName("Idx_fecha_final");

                entity.HasIndex(e => e.Fecha_inicio)
                    .HasName("Idx_fecha_inicio");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Fecha_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Codigo).ValueGeneratedOnAdd();

                entity.Property(e => e.Descuento).HasColumnType("smallmoney");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Incremento_porcentual)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Incremento_total)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operacion_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Precio_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo).HasColumnType("smallmoney");

                entity.Property(e => e.Situacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_temporal)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_temporal_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_temporal)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_precios_especiales_temporal_Clientes");

                entity.HasOne(d => d.SituacionNavigation)
                    .WithMany(p => p.Clientes_precios_especiales_temporal)
                    .HasForeignKey(d => d.Situacion)
                    .HasConstraintName("FK_Interlocutores_precios_especiales_temporal_Interlocutores_precios_tipos");
            });

            modelBuilder.Entity<Clientes_precios_procesos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_precios_procesos");

                entity.ToTable("Clientes_precios_procesos", "Precios");

                entity.Property(e => e.Descripcion).HasMaxLength(400);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Clientes_precios_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_precios_tipos");

                entity.ToTable("Clientes_precios_tipos", "Precios");

                entity.Property(e => e.Codigo).HasColumnType("nchar(10)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<Clientes_procesos>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Proceso })
                    .HasName("PK_Clientes_procesos");

                entity.ToTable("Clientes_procesos", "Gestion");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Proceso).HasColumnType("nchar(6)");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_procesos)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_procesos_Clientes");

                entity.HasOne(d => d.ProcesoNavigation)
                    .WithMany(p => p.Clientes_procesos)
                    .HasForeignKey(d => d.Proceso)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Clientes_procesos_Procesos_tipos");
            });

            modelBuilder.Entity<Clientes_rappels>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Clientes_rappels");

                entity.ToTable("Clientes_rappels", "Precios");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_final)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Objetivo_final).HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_inicial).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo).HasColumnType("nchar(1)");

                entity.Property(e => e.Validar_fecha).HasDefaultValueSql("0");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_rappels)
                    .HasForeignKey(d => d.Cliente)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Clientes_rappels_Clientes");
            });

            modelBuilder.Entity<Clientes_riesgos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Clientes_riesgos");

                entity.ToTable("Clientes_riesgos", "Gestion");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Credito_caucion).HasColumnType("nchar(10)");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Importe_actual)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Importe_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Clientes_riesgos_informacion>(entity =>
            {
                entity.HasKey(e => e.Cliente)
                    .HasName("PK_Clientes_riesgos_informacion");

                entity.ToTable("Clientes_riesgos_informacion", "Gestion");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Abonos_pendientes_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Abonos_pendientes_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Albaranes_no_facturados_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Albaranes_no_facturados_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Anticipos_pendientes_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Anticipos_pendientes_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cesiones_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Cesiones_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Facturas_pendientes_cobro_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Facturas_pendientes_cobro_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Pedidos_curso_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Pedidos_curso_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pedidos_pendientes_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Pedidos_pendientes_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proformas_pendientes_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Proformas_pendientes_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_cobrados_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_cobrados_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_en_riesgo_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_en_riesgo_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_impagados_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_impagados_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_incobrables_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_incobrables_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_no_controlados_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_no_controlados_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_normal_reclamados_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_normal_reclamados_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_normales_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_normales_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_nueva_gestion_ampliado_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_nueva_gestion_ampliado_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_nueva_gestion_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_nueva_gestion_sg_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_nueva_gestion_sg_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_nueva_gestion_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_prevision_pago_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_prevision_pago_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_reclamados_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_reclamados_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_remesados_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Recibos_remesados_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Riesgo_actual)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Clientes_sinonimos>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Articulo })
                    .HasName("PK_Clientes_sinonimos");

                entity.ToTable("Clientes_sinonimos", "Gestion");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Clientes_sinonimos)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Clientes_sinonimos_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_sinonimos)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_sinonimos_Clientes");
            });

            modelBuilder.Entity<Clientes_sugerencias>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_sugerencias");

                entity.ToTable("Clientes_sugerencias", "Gestion");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Respuesta_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Sugerencia_fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Clientes_transporte_expediciones>(entity =>
            {
                entity.HasKey(e => new { e.Agencia, e.Cliente })
                    .HasName("PK_Agencias_transporte_expediciones");

                entity.ToTable("Clientes_transporte_expediciones", "Gestion");

                entity.Property(e => e.Agencia).HasColumnType("nchar(6)");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Reexpedicion).HasDefaultValueSql("0");

                entity.HasOne(d => d.AgenciaNavigation)
                    .WithMany(p => p.Clientes_transporte_expediciones)
                    .HasForeignKey(d => d.Agencia)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Agencias_transporte_expediciones_Agencias_transporte");
            });

            modelBuilder.Entity<Clientes_valoracion>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Fecha })
                    .HasName("PK_Interlocutores_valoracion");

                entity.ToTable("Clientes_valoracion", "Gestion");

                entity.Property(e => e.Cliente).HasColumnType("char(6)");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Abonos).HasColumnType("smallmoney");

                entity.Property(e => e.Facturacion).HasColumnType("smallmoney");

                entity.Property(e => e.Impagados).HasColumnType("smallmoney");

                entity.Property(e => e.Rentabilidad).HasColumnType("smallmoney");
            });

            modelBuilder.Entity<Clientes_visitas>(entity =>
            {
                entity.HasKey(e => new { e.Cliente, e.Visita })
                    .HasName("PK_Clientes_visitas");

                entity.ToTable("Clientes_visitas", "Gestion");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Visita)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Clientes_visitas)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Clientes_visitas_Clientes");
            });

            modelBuilder.Entity<Clientes_zonas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_zonas");

                entity.ToTable("Clientes_zonas", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Objetivo_ejercicio1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_ejercicio2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_ejercicio3)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Zona_cc).HasColumnType("nchar(4)");

                entity.Property(e => e.Zona_duraccion_cc).HasDefaultValueSql("0");

                entity.Property(e => e.Zona_iva).HasMaxLength(30);

                entity.Property(e => e.Zona_politica).HasMaxLength(30);

                entity.Property(e => e.Zona_tipo).HasMaxLength(30);
            });

            modelBuilder.Entity<Codificacion_defectos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Calidad_Codificacion_Defectos");

                entity.ToTable("Codificacion_defectos", "Calidad");

                entity.Property(e => e.Codigo).HasColumnType("char(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("varchar(30)");

                entity.Property(e => e.Observaciones).HasColumnType("text");
            });

            modelBuilder.Entity<Colores_ral>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Colores_ral");

                entity.ToTable("Colores_ral", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Color).HasColumnType("nchar(25)");

                entity.Property(e => e.Descripcion_color).HasMaxLength(50);

                entity.Property(e => e.Descripcion_ral).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Competidores>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Competidores");

                entity.ToTable("Competidores", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Bloqueo_informacion).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_operaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Clave1).HasMaxLength(20);

                entity.Property(e => e.Clave2).HasMaxLength(20);

                entity.Property(e => e.Clave3).HasMaxLength(20);

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Fecha_alta).HasColumnType("smalldatetime");

                entity.Property(e => e.Ftp).HasMaxLength(100);

                entity.Property(e => e.Grafico).HasMaxLength(50);

                entity.Property(e => e.Grupo_sinonimos).HasColumnType("nchar(6)");

                entity.Property(e => e.Horario_descarga1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_descarga2).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina2).HasColumnType("nchar(5)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Numero).HasDefaultValueSql("0");

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Telefono3).HasMaxLength(30);

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Vacaciones_final).HasColumnType("nchar(5)");

                entity.Property(e => e.Vacaciones_inicio).HasColumnType("nchar(5)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);

                entity.Property(e => e.Zona).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Competidores_articulos_certificados>(entity =>
            {
                entity.HasKey(e => new { e.Competidor, e.Articulo, e.Certificacion })
                    .HasName("PK_Competidores_articulos_certificados");

                entity.ToTable("Competidores_articulos_certificados", "Gestion");

                entity.Property(e => e.Competidor).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Certificacion).HasColumnType("nchar(10)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Competidores_articulos_certificados)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Competidores_articulos_certificados_Articulos");

                entity.HasOne(d => d.CompetidorNavigation)
                    .WithMany(p => p.Competidores_articulos_certificados)
                    .HasForeignKey(d => d.Competidor)
                    .HasConstraintName("FK_Competidores_articulos_certificados_Competidores");
            });

            modelBuilder.Entity<Competidores_departamentos>(entity =>
            {
                entity.HasKey(e => new { e.Competidor, e.Tipo_departamento })
                    .HasName("PK_Competidores_departamentos");

                entity.ToTable("Competidores_departamentos", "Gestion");

                entity.Property(e => e.Competidor).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo_departamento).HasColumnType("nchar(2)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Persona_contacto).HasMaxLength(50);

                entity.HasOne(d => d.CompetidorNavigation)
                    .WithMany(p => p.Competidores_departamentos)
                    .HasForeignKey(d => d.Competidor)
                    .HasConstraintName("FK_Competidores_departamentos_Competidores");

                entity.HasOne(d => d.Tipo_departamentoNavigation)
                    .WithMany(p => p.Competidores_departamentos)
                    .HasForeignKey(d => d.Tipo_departamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Competidores_departamentos_Departamentos_tipos");
            });

            modelBuilder.Entity<Competidores_ofertas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Competidores_ofertas");

                entity.ToTable("Competidores_ofertas", "Gestion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Competidor).HasColumnType("nchar(6)");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_oferta)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Homogeiniciacion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Incoterm).HasColumnType("nchar(3)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Competidores_ofertas)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Interlocutores_competidores_ofertas_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Competidores_ofertas)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Competidores_ofertas_Clientes");

                entity.HasOne(d => d.CompetidorNavigation)
                    .WithMany(p => p.Competidores_ofertas)
                    .HasForeignKey(d => d.Competidor)
                    .HasConstraintName("FK_Competidores_ofertas_Competidores");
            });

            modelBuilder.Entity<Competidores_sinonimos>(entity =>
            {
                entity.HasKey(e => new { e.Competidor, e.Articulo })
                    .HasName("PK_Competidores_sinonimos");

                entity.ToTable("Competidores_sinonimos", "Gestion");

                entity.Property(e => e.Competidor).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.HasOne(d => d.CompetidorNavigation)
                    .WithMany(p => p.Competidores_sinonimos)
                    .HasForeignKey(d => d.Competidor)
                    .HasConstraintName("FK_Competidores_sinonimos_Competidores");
            });

            modelBuilder.Entity<Competidores_visitas>(entity =>
            {
                entity.HasKey(e => new { e.Competidor, e.Visita })
                    .HasName("PK_Competidores_visitas");

                entity.ToTable("Competidores_visitas", "Gestion");

                entity.Property(e => e.Competidor).HasColumnType("nchar(6)");

                entity.Property(e => e.Visita)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.CompetidorNavigation)
                    .WithMany(p => p.Competidores_visitas)
                    .HasForeignKey(d => d.Competidor)
                    .HasConstraintName("FK_Competidores_visitas_Competidores");
            });

            modelBuilder.Entity<Componentes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_componente");

                entity.ToTable("Componentes", "Carroceria");

                entity.HasIndex(e => new { e.Pieza, e.Componente })
                    .HasName("IX_Componentes")
                    .IsUnique();

                entity.Property(e => e.Componente)
                    .IsRequired()
                    .HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Pieza)
                    .IsRequired()
                    .HasColumnType("nchar(2)");

                entity.HasOne(d => d.PiezaNavigation)
                    .WithMany(p => p.Componentes)
                    .HasForeignKey(d => d.Pieza)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Componentes_Piezas");
            });

            modelBuilder.Entity<Compras_albaranes_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Compras_albaranes_cabecera");

                entity.ToTable("Compras_albaranes_cabecera", "Compras");

                entity.HasIndex(e => e.Aprobado)
                    .HasName("Idx_aprobado");

                entity.HasIndex(e => e.Ejercicio)
                    .HasName("Idx_Ejercicio");

                entity.HasIndex(e => e.Facturado)
                    .HasName("Idx_facturado");

                entity.HasIndex(e => e.Modo)
                    .HasName("Idx_Modo");

                entity.HasIndex(e => e.Proveedor)
                    .HasName("Idx_Interlocutor");

                entity.HasIndex(e => new { e.Albaran, e.Codigo })
                    .HasName("Idx_CodigoAlbaran");

                entity.HasIndex(e => new { e.Albaran, e.Modo, e.Ejercicio })
                    .HasName("_dta_index_Albaranes_cabecera_19_1048103966__K4_K3_2");

                entity.Property(e => e.Agencia_transporte).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaran).HasColumnType("nchar(6)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Almacen_destino).HasColumnType("nchar(3)");

                entity.Property(e => e.Almacen_origen).HasColumnType("nchar(3)");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("0");

                entity.Property(e => e.Base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Calidad_documentacion).HasDefaultValueSql("1");

                entity.Property(e => e.Calidad_documentacion_servicios).HasDefaultValueSql("1");

                entity.Property(e => e.Calidad_embalajes).HasDefaultValueSql("1");

                entity.Property(e => e.Calidad_incidencias).HasMaxLength(2000);

                entity.Property(e => e.Calidad_tipo_servicio).HasDefaultValueSql("1");

                entity.Property(e => e.Calidad_valoracion).HasDefaultValueSql("1");

                entity.Property(e => e.Decimales_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_precios).HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_totales).HasDefaultValueSql("0");

                entity.Property(e => e.Departamento).HasColumnType("nchar(3)");

                entity.Property(e => e.Descuento_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_pronto_pago)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_volumen)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_decimales).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_enteros).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Factor_impresion).HasColumnType("decimal");

                entity.Property(e => e.Factura_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Facturado).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_albaran)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_aprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_entrega).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_factura).HasColumnType("smalldatetime");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Incoterm1).HasColumnType("nchar(5)");

                entity.Property(e => e.Incoterm2).HasColumnType("nchar(5)");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones_generales).HasMaxLength(2000);

                entity.Property(e => e.Pedido_restos).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_restos_generar).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_real)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuentos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Portes_iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_observaciones).HasMaxLength(2000);

                entity.Property(e => e.Portes_re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("3");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Proveedor_empresa).HasMaxLength(50);

                entity.Property(e => e.Recargo_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_financiero)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reclamacion_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Retencion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Subcuenta_gastos).HasColumnType("nchar(20)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_pronto_pago)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_volumen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_divisa_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes_suplementos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_general)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_portes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_equivalencia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_financiero)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_retencion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Total_volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.DepartamentoNavigation)
                    .WithMany(p => p.Compras_albaranes_cabecera)
                    .HasForeignKey(d => d.Departamento)
                    .HasConstraintName("FK_Albaranes_cabecera_Personal_departamentos");

                entity.HasOne(d => d.Forma_pagoNavigation)
                    .WithMany(p => p.Compras_albaranes_cabecera)
                    .HasForeignKey(d => d.Forma_pago)
                    .HasConstraintName("FK_Albaranes_cabecera_Formas_pago");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Compras_albaranes_cabecera)
                    .HasForeignKey(d => d.Iva)
                    .HasConstraintName("FK_Compras_albaranes_cabecera_Ivas");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Compras_albaranes_cabecera)
                    .HasForeignKey(d => d.Proveedor)
                    .HasConstraintName("FK_Compras_albaranes_cabecera_Proveedores");
            });

            modelBuilder.Entity<Compras_albaranes_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Compras_albaranes_detalle");

                entity.ToTable("Compras_albaranes_detalle", "Compras");

                entity.HasIndex(e => new { e.Iva, e.Codigo })
                    .HasName("_dta_index_Albaranes_detalle_19_1739582427__K19_K2");

                entity.HasIndex(e => new { e.Numero, e.Codigo, e.Reclamacion_numero_linea })
                    .HasName("_dta_index_Albaranes_detalle_19_1739582427__K2_K28_1");

                entity.HasIndex(e => new { e.Precio, e.Re_porcentaje, e.Numero, e.Cantidad, e.Descuento, e.Iva_porcentaje, e.Almacen, e.Codigo, e.Articulo })
                    .HasName("_dta_index_Albaranes_detalle_19_1739582427__K2_K4_1_6_12_16_18_20_21");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_totales_peso).HasDefaultValueSql("0");

                entity.Property(e => e.Calidad_especifica).HasColumnType("nchar(4)");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Etiqueta).HasColumnType("nchar(3)");

                entity.Property(e => e.Factura_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Factura_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo).HasColumnType("nchar(20)");

                entity.Property(e => e.Pedidas)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pedido_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Pendientes)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_etiqueta)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reclamacion_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Stocks).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_precio).HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_linea)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_re)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Compras_albaranes_detalle)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Compras_albaranes_detalle_Articulos");

                entity.HasOne(d => d.Calidad_especificaNavigation)
                    .WithMany(p => p.Compras_albaranes_detalle)
                    .HasForeignKey(d => d.Calidad_especifica)
                    .HasConstraintName("FK_Compras_albaranes_detalle_Articulos_chapa_calidad");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Compras_albaranes_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Compras_albaranes_detalle_Compras_albaranes_cabecera");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Compras_albaranes_detalle)
                    .HasForeignKey(d => d.Iva)
                    .HasConstraintName("FK_Albaranes_detalle_Ivas");
            });

            modelBuilder.Entity<Compras_albaranes_entradas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_albaranes_entradas");

                entity.ToTable("Compras_albaranes_entradas", "Picking");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_Articulo");

                entity.HasIndex(e => e.Fecha_entrada)
                    .HasName("Idx_FechaEntrada");

                entity.HasIndex(e => e.Jaula)
                    .HasName("Idx_Jaula");

                entity.HasIndex(e => e.Operario)
                    .HasName("Idx_Operario");

                entity.HasIndex(e => e.Procesada)
                    .HasName("Idx_Procesada");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Entrada).HasDefaultValueSql("0");

                entity.Property(e => e.Entradas_almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Entradas_ubicacion).HasColumnType("nchar(5)");

                entity.Property(e => e.Fecha_entrada)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Jaula).HasColumnType("nchar(10)");

                entity.Property(e => e.Operario).HasColumnType("nchar(5)");

                entity.Property(e => e.Picking_almacen)
                    .HasColumnType("nchar(3)")
                    .HasDefaultValueSql("'010'");

                entity.Property(e => e.Picking_ubicacion)
                    .HasColumnType("nchar(5)")
                    .HasDefaultValueSql("'UBI001'");

                entity.Property(e => e.Procesada).HasDefaultValueSql("0");

                entity.Property(e => e.Stock).HasDefaultValueSql("0");

                entity.Property(e => e.Tracking).HasColumnType("nchar(20)");

                entity.HasOne(d => d.Pedido_numero_lineaNavigation)
                    .WithMany(p => p.Compras_albaranes_entradas)
                    .HasForeignKey(d => d.Pedido_numero_linea)
                    .HasConstraintName("FK_Compras_albaranes_entradas_Compras_pedidos_detalle");

                entity.HasOne(d => d.Picking_almacenNavigation)
                    .WithMany(p => p.Compras_albaranes_entradas)
                    .HasForeignKey(d => d.Picking_almacen)
                    .HasConstraintName("FK_Compras_albaranes_entradas_Almacen");
            });

            modelBuilder.Entity<Compras_albaranes_entradas_log>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Compras_albaranes_entradas_log");

                entity.ToTable("Compras_albaranes_entradas_log", "Picking");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Operario).HasColumnType("nchar(5)");

                entity.Property(e => e.Tracking).HasColumnType("nchar(20)");
            });

            modelBuilder.Entity<Compras_facturas_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Compras_facturas_cabecera");

                entity.ToTable("Compras_facturas_cabecera", "Compras");

                entity.HasIndex(e => new { e.Factura, e.Ejercicio, e.Modo })
                    .HasName("FacturaEjercicioModo")
                    .IsUnique();

                entity.Property(e => e.Abono_rappel).HasDefaultValueSql("0");

                entity.Property(e => e.Agencia_transporte).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Analitica_verificada).HasDefaultValueSql("0");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("0");

                entity.Property(e => e.Asiento).HasDefaultValueSql("0");

                entity.Property(e => e.Base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_cartera).HasDefaultValueSql("0");

                entity.Property(e => e.Cierre).HasDefaultValueSql("0");

                entity.Property(e => e.Contabilizada).HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_precios).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_totales).HasDefaultValueSql("2");

                entity.Property(e => e.Departamento).HasColumnType("nchar(3)");

                entity.Property(e => e.Descuento_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_pronto_pago)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_volumen)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_decimales).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_enteros).HasDefaultValueSql("0");

                entity.Property(e => e.Dua_numero).HasColumnType("nchar(10)");

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Factor_impresion).HasColumnType("decimal");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Fecha_aprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_factura)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Incoterm1).HasColumnType("nchar(5)");

                entity.Property(e => e.Incoterm2).HasColumnType("nchar(5)");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Material_origen).HasColumnType("nchar(30)");

                entity.Property(e => e.Mes).HasColumnType("nchar(2)");

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones_administrativas).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_forma_pago).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_generales).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_mercancias).HasMaxLength(2000);

                entity.Property(e => e.Pagada).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_aduanas)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_aranceles)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_real)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_transporte)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_varios)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descripcion_varios).HasMaxLength(2000);

                entity.Property(e => e.Portes_descuento_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuentos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_factura_aduanas).HasColumnType("nchar(20)");

                entity.Property(e => e.Portes_factura_transporte).HasColumnType("nchar(20)");

                entity.Property(e => e.Portes_fecha_cmr).HasColumnType("smalldatetime");

                entity.Property(e => e.Portes_iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Portes_iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_observaciones).HasMaxLength(2000);

                entity.Property(e => e.Portes_re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_verificado).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_volumen_cmr)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Proveedor_empresa).HasMaxLength(50);

                entity.Property(e => e.Recargo_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_financiero)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Registro_aduanas).HasColumnType("nchar(10)");

                entity.Property(e => e.Registro_aduanas_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Retencion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Subcuenta_gastos).HasColumnType("nchar(20)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_pronto_pago)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_volumen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_divisa_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes_suplementos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_general)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_portes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_equivalencia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_financiero)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_retencion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Total_volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tratamiento_especial).HasDefaultValueSql("0");

                entity.Property(e => e.Tratamiento_especial_irpf).HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.Property(e => e.Zona_iva).HasMaxLength(50);

                entity.Property(e => e.Zona_politica).HasMaxLength(50);

                entity.Property(e => e.Zona_tipo).HasMaxLength(50);

                entity.HasOne(d => d.DepartamentoNavigation)
                    .WithMany(p => p.Compras_facturas_cabecera)
                    .HasForeignKey(d => d.Departamento)
                    .HasConstraintName("FK_Facturas_cabecera_Personal_departamentos");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Compras_facturas_cabecera)
                    .HasForeignKey(d => d.Iva)
                    .HasConstraintName("FK_Facturas_cabecera_Ivas");
            });

            modelBuilder.Entity<Compras_facturas_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Compras_facturas_detalle");

                entity.ToTable("Compras_facturas_detalle", "Compras");

                entity.Property(e => e.Albaran_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaran_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_totales_peso).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Etiqueta).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo).HasMaxLength(20);

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_etiqueta)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Stocks).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_precio).HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_linea)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_re)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Compras_facturas_detalle)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Facturas_detalle_Almacen");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Compras_facturas_detalle)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Compras_Facturas_detalle_Articulos");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Compras_facturas_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Compras_facturas_detalle_Compras_facturas_cabecera");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Compras_facturas_detalle)
                    .HasForeignKey(d => d.Iva)
                    .HasConstraintName("FK_Facturas_detalle_Ivas");
            });

            modelBuilder.Entity<Compras_facturas_detalle_cuentas>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Facturas_detalle_cuentas1");

                entity.ToTable("Compras_facturas_detalle_cuentas", "Compras");

                entity.HasIndex(e => e.Codigo)
                    .HasName("Idx_Codigo");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(128);

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Re_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_linea)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_re)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Compras_facturas_detalle_cuentas)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Compras_facturas_detalle_cuentas_Compras_facturas_cabecera");
            });

            modelBuilder.Entity<Compras_facturas_periodos_cierre>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Compras_facturas_periodos_cierre");

                entity.ToTable("Compras_facturas_periodos_cierre", "Compras");

                entity.HasIndex(e => new { e.Ejercicio, e.Mes })
                    .HasName("Idx_EjercicioMes")
                    .IsUnique();

                entity.Property(e => e.Cierre).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");
            });

            modelBuilder.Entity<Compras_pedidos_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores_pedidos_cabecera");

                entity.ToTable("Compras_pedidos_cabecera", "Compras");

                entity.HasIndex(e => e.Aprobado)
                    .HasName("Idx_Aprobado");

                entity.HasIndex(e => e.Departamento)
                    .HasName("Idx_Departamento");

                entity.HasIndex(e => e.Ejercicio)
                    .HasName("Idx_Ejercicio");

                entity.HasIndex(e => e.Fecha_entrega)
                    .HasName("Idx_FechaEntrega");

                entity.HasIndex(e => e.Fecha_pedido)
                    .HasName("Idx_FechaPedido");

                entity.HasIndex(e => e.Modo)
                    .HasName("Idx_Modo");

                entity.HasIndex(e => e.Pedido)
                    .HasName("Idx_Pedido");

                entity.HasIndex(e => e.Proforma)
                    .HasName("Idx_Proforma");

                entity.HasIndex(e => e.Proveedor)
                    .HasName("Idx_Proveedor");

                entity.Property(e => e.Agencia_transporte).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("0");

                entity.Property(e => e.Base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_precios).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_totales).HasDefaultValueSql("2");

                entity.Property(e => e.Departamento).HasColumnType("nchar(3)");

                entity.Property(e => e.Descuento_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_pronto_pago)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_volumen)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_decimales).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_enteros).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Factor_impresion).HasColumnType("decimal");

                entity.Property(e => e.Fecha_aprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_entrega).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_pedido)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Incoterm1).HasColumnType("nchar(5)");

                entity.Property(e => e.Incoterm2).HasColumnType("nchar(5)");

                entity.Property(e => e.Internet_bloqueado).HasDefaultValueSql("0");

                entity.Property(e => e.Internet_procesado).HasDefaultValueSql("0");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones_generales).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_pedido).HasMaxLength(2000);

                entity.Property(e => e.Pedido).HasColumnType("nchar(6)");

                entity.Property(e => e.Planificado).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuentos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Portes_iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_observaciones).HasMaxLength(2000);

                entity.Property(e => e.Portes_re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargos)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("3");

                entity.Property(e => e.Proforma_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Proveedor_empresa).HasMaxLength(50);

                entity.Property(e => e.Recargo_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_financiero)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Restos_notificaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Restos_notificaciones_contador).HasDefaultValueSql("0");

                entity.Property(e => e.Restos_notificaciones_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Retencion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Subcuenta_gastos).HasColumnType("nchar(20)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_pronto_pago)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_volumen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_divisa_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes_suplementos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_general)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_portes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_equivalencia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_financiero)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_retencion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Total_volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Compras_pedidos_cabecera)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Compas_pedidos_cabecera_Almacen");

                entity.HasOne(d => d.DepartamentoNavigation)
                    .WithMany(p => p.Compras_pedidos_cabecera)
                    .HasForeignKey(d => d.Departamento)
                    .HasConstraintName("FK_Pedidos_cabecera_Personal_departamentos");

                entity.HasOne(d => d.Forma_pagoNavigation)
                    .WithMany(p => p.Compras_pedidos_cabecera)
                    .HasForeignKey(d => d.Forma_pago)
                    .HasConstraintName("FK_Compras_pedidos_cabecera_Formas_pago");

                entity.HasOne(d => d.Incoterm1Navigation)
                    .WithMany(p => p.Compras_pedidos_cabecera)
                    .HasForeignKey(d => d.Incoterm1)
                    .HasConstraintName("FK_Pedidos_cabecera_Incoterms");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Compras_pedidos_cabecera)
                    .HasForeignKey(d => d.Iva)
                    .HasConstraintName("FK_Pedidos_cabecera_Ivas");

                entity.HasOne(d => d.ProformaNavigation)
                    .WithMany(p => p.Compras_pedidos_cabecera)
                    .HasForeignKey(d => d.Proforma)
                    .HasConstraintName("FK_Pedidos_cabecera_Proformas_cabecera");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Compras_pedidos_cabecera)
                    .HasForeignKey(d => d.Proveedor)
                    .HasConstraintName("FK_Compras_pedidos_cabecera_Proveedores");
            });

            modelBuilder.Entity<Compras_pedidos_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Proveedores_pedidos_detalle");

                entity.ToTable("Compras_pedidos_detalle", "Compras");

                entity.HasIndex(e => new { e.Codigo, e.Total_linea, e.Bloqueada, e.Completada, e.Articulo, e.Almacen, e.Pendientes })
                    .HasName("Idx_ComprasPendientes");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Base).HasDefaultValueSql("1");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_totales_peso).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(2)");

                entity.Property(e => e.Completada).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Etiqueta).HasColumnType("nchar(3)");

                entity.Property(e => e.Fabricacion_marca).HasColumnType("nchar(5)");

                entity.Property(e => e.Formatos)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Linea).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo).HasMaxLength(20);

                entity.Property(e => e.Pendientes)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_etiqueta)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Servidas)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo_precio).HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_linea)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_re)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Compras_pedidos_detalle)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Compras_pedidos_detalle_Almacen1");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Compras_pedidos_detalle)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Compras_pedidos_detalle_Articulos");

                entity.HasOne(d => d.Centro_costeNavigation)
                    .WithMany(p => p.Compras_pedidos_detalle)
                    .HasForeignKey(d => d.Centro_coste)
                    .HasConstraintName("FK_Compras_pedidos_detalle_Interlocutores_centros_coste");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Compras_pedidos_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Compras_pedidos_detalle_Compras_pedidos_cabecera");

                entity.HasOne(d => d.EtiquetaNavigation)
                    .WithMany(p => p.Compras_pedidos_detalle)
                    .HasForeignKey(d => d.Etiqueta)
                    .HasConstraintName("FK_Compras_pedidos_detalle_Embalajes");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Compras_pedidos_detalle)
                    .HasForeignKey(d => d.Iva)
                    .HasConstraintName("FK_Compras_pedidos_detalle_Ivas");
            });

            modelBuilder.Entity<Compras_prestamo_material>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Prestamo_material");

                entity.ToTable("Compras_prestamo_material", "Compras");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Devolucion).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Operario).HasColumnType("nchar(5)");

                entity.Property(e => e.Prestamo).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Compras_proformas_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Compras_proformas_cabecera");

                entity.ToTable("Compras_proformas_cabecera", "Compras");

                entity.HasIndex(e => e.Aprobado)
                    .HasName("Idx_Aprobado");

                entity.HasIndex(e => e.Departamento)
                    .HasName("Idx_Departamento");

                entity.HasIndex(e => e.Ejercicio)
                    .HasName("Idx_Ejercicio");

                entity.HasIndex(e => e.Fecha_proforma)
                    .HasName("Idx_FechaProforma");

                entity.HasIndex(e => e.Modo)
                    .HasName("Idx_Modo");

                entity.HasIndex(e => e.Proforma)
                    .HasName("Idx_Proforma");

                entity.HasIndex(e => e.Proveedor)
                    .HasName("Idx_Proveedor");

                entity.HasIndex(e => new { e.Ejercicio, e.Modo })
                    .HasName("Idx_EjercicioModo");

                entity.HasIndex(e => new { e.Proforma, e.Ejercicio, e.Modo })
                    .HasName("ProformaEjercicioModo")
                    .IsUnique();

                entity.Property(e => e.Agencia_transporte).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("0");

                entity.Property(e => e.Base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Codaux).HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_cantidad).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_precios).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_totales).HasDefaultValueSql("2");

                entity.Property(e => e.Departamento).HasColumnType("nchar(3)");

                entity.Property(e => e.Descuento_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_pronto_pago)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_volumen)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_decimales).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_enteros).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Factor_impresion).HasColumnType("decimal");

                entity.Property(e => e.Fecha_aprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_proforma)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_validez).HasColumnType("smalldatetime");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Incoterm1).HasColumnType("nchar(5)");

                entity.Property(e => e.Incoterm2).HasColumnType("nchar(5)");

                entity.Property(e => e.Internet_bloqueado).HasDefaultValueSql("0");

                entity.Property(e => e.Internet_procesado).HasDefaultValueSql("0");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones_generales).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_proforma).HasMaxLength(2000);

                entity.Property(e => e.Pedido_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Portes_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuentos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Portes_iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_observaciones).HasMaxLength(2000);

                entity.Property(e => e.Portes_re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("3");

                entity.Property(e => e.Proforma)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Proveedor_empresa).HasMaxLength(50);

                entity.Property(e => e.Recargo_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_financiero)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Retencion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Subcuenta_gastos).HasColumnType("nchar(20)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_pronto_pago)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_volumen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_divisa_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes_suplementos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_general)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_portes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_equivalencia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_financiero)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_retencion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Total_volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.DepartamentoNavigation)
                    .WithMany(p => p.Compras_proformas_cabecera)
                    .HasForeignKey(d => d.Departamento)
                    .HasConstraintName("FK_Proformas_cabecera_Personal_departamentos");

                entity.HasOne(d => d.Forma_pagoNavigation)
                    .WithMany(p => p.Compras_proformas_cabecera)
                    .HasForeignKey(d => d.Forma_pago)
                    .HasConstraintName("FK_Proformas_cabecera_Formas_pago");

                entity.HasOne(d => d.Incoterm1Navigation)
                    .WithMany(p => p.Compras_proformas_cabeceraIncoterm1Navigation)
                    .HasForeignKey(d => d.Incoterm1)
                    .HasConstraintName("FK_Proformas_cabecera_Incoterms");

                entity.HasOne(d => d.Incoterm2Navigation)
                    .WithMany(p => p.Compras_proformas_cabeceraIncoterm2Navigation)
                    .HasForeignKey(d => d.Incoterm2)
                    .HasConstraintName("FK_Proformas_cabecera_Incoterms1");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Compras_proformas_cabecera)
                    .HasForeignKey(d => d.Iva)
                    .HasConstraintName("FK_Proformas_cabecera_Ivas");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Compras_proformas_cabecera)
                    .HasForeignKey(d => d.Proveedor)
                    .HasConstraintName("FK_Compras_proformas_cabecera_Proveedores");
            });

            modelBuilder.Entity<Compras_proformas_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Proformas_detalle");

                entity.ToTable("Compras_proformas_detalle", "Compras");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_totales_peso).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(200)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Etiqueta).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo).HasMaxLength(20);

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_etiqueta)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo_precio).HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_linea)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_re)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Compras_proformas_detalle)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Proformas_detalle_Almacen");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Compras_proformas_detalle)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Compras_proformas_detalle_Articulos");

                entity.HasOne(d => d.Centro_costeNavigation)
                    .WithMany(p => p.Compras_proformas_detalle)
                    .HasForeignKey(d => d.Centro_coste)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proformas_detalle_Interlocutores_centros_coste");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Compras_proformas_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Compras_proformas_detalle_Compas_proformas_cabecera");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Compras_proformas_detalle)
                    .HasForeignKey(d => d.Iva)
                    .HasConstraintName("FK_Proformas_detalle_Ivas");
            });

            modelBuilder.Entity<Compras_proveedores_articulos_presupuestados>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Compras_proveedores_articulos_presupuestados");

                entity.ToTable("Compras_proveedores_articulos_presupuestados", "Compras");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Descuento)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Plazo).HasDefaultValueSql("0");

                entity.Property(e => e.Precios)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proforma).HasColumnType("nchar(6)");
            });

            modelBuilder.Entity<Compras_reclamaciones_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Compras_reclamaciones_cabecera");

                entity.ToTable("Compras_reclamaciones_cabecera", "Compras");

                entity.Property(e => e.Abono_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Abono_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("0");

                entity.Property(e => e.Confirmar).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Enviada).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_reclamacion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Internet_procesado).HasDefaultValueSql("0");

                entity.Property(e => e.Modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Proveedor_empresa).HasMaxLength(50);

                entity.Property(e => e.Reclamacion).HasColumnType("nchar(6)");

                entity.Property(e => e.Referencia).HasColumnType("nchar(20)");

                entity.Property(e => e.Responsable1).HasColumnType("nchar(5)");

                entity.Property(e => e.Responsable2).HasColumnType("nchar(5)");

                entity.Property(e => e.Serie)
                    .HasColumnType("nchar(1)")
                    .HasDefaultValueSql("N'A'");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Compras_reclamaciones_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Compras_reclamaciones_detalle");

                entity.ToTable("Compras_reclamaciones_detalle", "Compras");

                entity.HasIndex(e => e.Codigo)
                    .HasName("_dta_index_Reclamaciones_detalle_19_1062008006__K2");

                entity.HasIndex(e => new { e.Bloqueada, e.Unidades_abonadas, e.Numero, e.Factura_numero_linea })
                    .HasName("_dta_index_Reclamaciones_detalle_19_1062008006__K24_K12_K1_K17");

                entity.Property(e => e.Albaran_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Albaran_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaran_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Factura_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Factura_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Factura_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Incidencias).HasMaxLength(2000);

                entity.Property(e => e.Linea).HasDefaultValueSql("0");

                entity.Property(e => e.Motivo).HasColumnType("nchar(20)");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Stocks).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_abonadas).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_enviadas).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_reclamadas).HasDefaultValueSql("0");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Compras_reclamaciones_detalle)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Reclamaciones_detalle_Almacen");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Compras_reclamaciones_detalle)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Reclamaciones_detalle_Articulos");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Compras_reclamaciones_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .HasConstraintName("FK_Compras_reclamaciones_detalle_Compras_reclamaciones_cabecera");
            });

            modelBuilder.Entity<Contenedores_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Jaulas_tipos");

                entity.ToTable("Contenedores_tipos", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Observaciones).HasMaxLength(1000);

                entity.Property(e => e.Volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Controles_requeridos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Controles_requeridos");

                entity.ToTable("Controles_requeridos", "General");

                entity.Property(e => e.Control_nombre).HasColumnType("nchar(200)");

                entity.Property(e => e.Formulario).HasMaxLength(200);
            });

            modelBuilder.Entity<Costes_articulos_configuracion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_configuracion");

                entity.ToTable("Costes_articulos_configuracion", "Planificacion");

                entity.HasIndex(e => e.Almacen)
                    .HasName("Idx_Almacen");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_Articulo");

                entity.HasIndex(e => new { e.Articulo, e.Almacen })
                    .HasName("Idx_AlmacenArticulo")
                    .IsUnique();

                entity.Property(e => e.Almacen)
                    .IsRequired()
                    .HasColumnType("nchar(3)")
                    .HasDefaultValueSql("'001'");

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Coste_actual)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_alquiler)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_energia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_financiacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_manipulacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_mano_obra)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_mantenimiento)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_mantenimiento_fijo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_mantenimiento_variable)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_medios)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_obsolescencia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_optimo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_preparacion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_seguro_contenido)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Demanda_media)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_ultima_actualizacion)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lote_entrega_actual)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Lote_entrega_calculado)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operarios_preparacion_externa)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Operarios_preparacion_interna)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Punto_pedido_actual)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Punto_pedido_calculado)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tiempo_preparacion_externa)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tiempo_preparacion_interna)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_jaula)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Costes_configuracion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Costes_configuracion");

                entity.ToTable("Costes_configuracion", "Planificacion");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Almacen_altura)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Almacen_aprovechamiento)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_alquiler)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_alquiler_descripcion).HasMaxLength(100);

                entity.Property(e => e.Coste_carretillas)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_energia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_estanterias)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_financiacion)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_hora_maquina_parada)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_mano_obra)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_mantenimiento_financiero)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_medios_transporte)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_medios_transporte_descripcion).HasMaxLength(100);

                entity.Property(e => e.Coste_obsolescencia)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_operario)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_operario_descripcion).HasMaxLength(100);

                entity.Property(e => e.Coste_preparacion_externa_operarios)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_preparacion_fijo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_preparacion_interna_operarios)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_preparacion_linea_engatillado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_preparacion_linea_engatillado_descripcion).HasMaxLength(100);

                entity.Property(e => e.Coste_preparacion_linea_prensas)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_preparacion_linea_prensas_descripcion).HasMaxLength(100);

                entity.Property(e => e.Coste_preparacion_linea_soldadura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_preparacion_linea_soldadura_descripcion).HasMaxLength(100);

                entity.Property(e => e.Coste_seguro_contenido)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Demanda_media_meses).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Dias_laborables).HasDefaultValueSql("221");

                entity.Property(e => e.Fecha_proxima_ejecucion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_ultima_actualización).HasColumnType("smalldatetime");

                entity.Property(e => e.Imputacion_coste_maquina_parada).HasDefaultValueSql("0");

                entity.Property(e => e.Lote_entrega_stock_minimo).HasDefaultValueSql("0");

                entity.Property(e => e.Lote_entrega_stock_seguridad).HasDefaultValueSql("0");

                entity.Property(e => e.Operarios_desplazamiento).HasDefaultValueSql("0");

                entity.Property(e => e.Periodicidad).HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_nacional_inmediato)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Punto_pedido_stock_minimo).HasDefaultValueSql("0");

                entity.Property(e => e.Punto_pedido_stock_seguridad).HasDefaultValueSql("0");

                entity.Property(e => e.Stock_seguridad).HasDefaultValueSql("0");

                entity.Property(e => e.Superficie_estanterias)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tipo).HasColumnType("nchar(1)");

                entity.Property(e => e.Total_coste_mantenimiento_volumen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_coste_medios)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_coste_volumen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_jaula)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_medio)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_util)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Costes_configuracion_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Costes_configuracion_tipos");

                entity.ToTable("Costes_configuracion_tipos", "Planificacion");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Observaciones).HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<Cuentas_contables_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Cuentas_contables_tipos");

                entity.ToTable("Cuentas_contables_tipos", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Departamentos_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Departamentos_tipos");

                entity.ToTable("Departamentos_tipos", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Direcciones_mails_direcciones>(entity =>
            {
                entity.HasKey(e => new { e.Direccion, e.Tipo_mail })
                    .HasName("PK_Direcciones_mails_direcciones");

                entity.ToTable("Direcciones_mails_direcciones", "Gestion");

                entity.Property(e => e.Tipo_mail).HasColumnType("nchar(2)");

                entity.Property(e => e.Email).HasMaxLength(100);
            });

            modelBuilder.Entity<Direcciones_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Direcciones_tipos");

                entity.ToTable("Direcciones_tipos", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Documentacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_documentacion");

                entity.ToTable("Documentacion", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(4)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(100)");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Documentacion_archivos>(entity =>
            {
                entity.ToTable("Documentacion_archivos", "General");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.SystemNumber).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Documentacion_conceptos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Documentacion_facturacion_conceptos");

                entity.ToTable("Documentacion_conceptos", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Grupo).HasColumnType("nchar(2)");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Documentacion_conceptos)
                    .HasForeignKey(d => d.Grupo)
                    .HasConstraintName("FK_Documentacion_conceptos_Documentacion_grupos");
            });

            modelBuilder.Entity<Documentacion_configuracion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_documentacion_configuracion");

                entity.ToTable("Documentacion_configuracion", "General");

                entity.Property(e => e.Concepto).HasColumnType("nchar(3)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Documentacion).HasColumnType("nchar(4)");

                entity.Property(e => e.Grupo).HasColumnType("nchar(2)");

                entity.Property(e => e.Texto).HasMaxLength(50);

                entity.HasOne(d => d.ConceptoNavigation)
                    .WithMany(p => p.Documentacion_configuracion)
                    .HasForeignKey(d => d.Concepto)
                    .HasConstraintName("FK_Documentacion_configuracion_Documentacion_conceptos");

                entity.HasOne(d => d.DocumentacionNavigation)
                    .WithMany(p => p.Documentacion_configuracion)
                    .HasForeignKey(d => d.Documentacion)
                    .HasConstraintName("FK_Documentacion_configuracion_Documentacion1");
            });

            modelBuilder.Entity<Documentacion_grupos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Documentacion_tipos");

                entity.ToTable("Documentacion_grupos", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Embalajes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Embalajes");

                entity.ToTable("Embalajes", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Activo).HasDefaultValueSql("0");

                entity.Property(e => e.Altura).HasColumnType("decimal");

                entity.Property(e => e.Anchura).HasColumnType("decimal");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Control_stocks).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Grafico).HasMaxLength(100);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_mano_obra)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_embalaje).HasColumnType("nchar(2)");

                entity.Property(e => e.Valor)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ValorCodigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Embalajes_cajas_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_embalajes_cajas_tipos");

                entity.ToTable("Embalajes_cajas_tipos", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(1)");

                entity.Property(e => e.Alto).HasColumnType("decimal");

                entity.Property(e => e.Ancho).HasColumnType("decimal");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Largo).HasColumnType("decimal");

                entity.Property(e => e.Observaciones).HasMaxLength(500);
            });

            modelBuilder.Entity<Embalajes_idiomas>(entity =>
            {
                entity.HasKey(e => new { e.Embalaje, e.Idioma })
                    .HasName("PK_Idiomas_embalajes");

                entity.ToTable("Embalajes_idiomas", "Logistica");

                entity.Property(e => e.Embalaje).HasColumnType("nchar(3)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Traduccion).HasMaxLength(254);

                entity.HasOne(d => d.EmbalajeNavigation)
                    .WithMany(p => p.Embalajes_idiomas)
                    .HasForeignKey(d => d.Embalaje)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Embalajes_idiomas_Embalajes");

                entity.HasOne(d => d.IdiomaNavigation)
                    .WithMany(p => p.Embalajes_idiomas)
                    .HasForeignKey(d => d.Idioma)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Embalajes_idiomas_Lenguajes");
            });

            modelBuilder.Entity<Embalajes_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Embalajes_tipos");

                entity.ToTable("Embalajes_tipos", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Empresa_activa>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Empresa_activa");

                entity.ToTable("Empresa_activa", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");
            });

            modelBuilder.Entity<Errores_sistema>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Errores_sistema");

                entity.ToTable("Errores_sistema", "General");

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.Destinatarios).HasMaxLength(1000);

                entity.Property(e => e.Error_message).HasMaxLength(2000);

                entity.Property(e => e.Error_procedure).HasMaxLength(1000);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Estadistica_ventas_coches_europa>(entity =>
            {
                entity.HasKey(e => new { e.Subfamilia, e.Ejercicio })
                    .HasName("PK_Estadistica_ventas_coches_europa");

                entity.ToTable("Estadistica_ventas_coches_europa", "Ventas");

                entity.Property(e => e.Subfamilia).HasColumnType("char(4)");

                entity.Property(e => e.Ejercicio).HasColumnType("char(4)");

                entity.Property(e => e.Modelo).HasColumnType("varchar(50)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(50)");

                entity.Property(e => e.Total).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Estadisticas>(entity =>
            {
                entity.HasKey(e => e.Clave)
                    .HasName("PK_Estadisticas");

                entity.ToTable("Estadisticas", "General");

                entity.Property(e => e.Clave).ValueGeneratedNever();

                entity.Property(e => e.Acceso).HasDefaultValueSql("0");

                entity.Property(e => e.Activa).HasDefaultValueSql("0");

                entity.Property(e => e.Contador).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Fecha_ultima_ejecucion).HasColumnType("datetime");

                entity.Property(e => e.Imagen).HasDefaultValueSql("0");

                entity.Property(e => e.Informe).HasColumnType("nchar(10)");

                entity.Property(e => e.Listas_corchetes).HasDefaultValueSql("0");

                entity.Property(e => e.Metodo).HasMaxLength(50);

                entity.Property(e => e.Ruta).HasMaxLength(100);
            });

            modelBuilder.Entity<Estadisticas_listas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Estadisticas_Listas");

                entity.ToTable("Estadisticas_listas", "General");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Tipo).HasMaxLength(50);
            });

            modelBuilder.Entity<Estadisticas_usuarios>(entity =>
            {
                entity.HasKey(e => new { e.Estadistica, e.Usuario })
                    .HasName("PK_Estadisticas_usuarios");

                entity.ToTable("Estadisticas_usuarios", "General");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.EstadisticaNavigation)
                    .WithMany(p => p.Estadisticas_usuarios)
                    .HasForeignKey(d => d.Estadistica)
                    .HasConstraintName("FK_Estadisticas_usuarios_Estadisticas");
            });

            modelBuilder.Entity<Etiquetas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Articulos_etiquetas");

                entity.ToTable("Etiquetas", "Gestion");

                entity.Property(e => e.Articulo).HasMaxLength(20);

                entity.Property(e => e.Articulo_etiqueta).HasMaxLength(30);

                entity.Property(e => e.CPostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Codigo_barras).HasMaxLength(50);

                entity.Property(e => e.Codigo_empresa).HasColumnType("nchar(10)");

                entity.Property(e => e.Departamento).HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Descripcion_idioma).HasMaxLength(100);

                entity.Property(e => e.Destino).HasMaxLength(50);

                entity.Property(e => e.Direccion).HasMaxLength(100);

                entity.Property(e => e.Ean13).HasColumnType("nchar(13)");

                entity.Property(e => e.Ean13b).HasColumnType("nchar(13)");

                entity.Property(e => e.Empresa).HasMaxLength(100);

                entity.Property(e => e.Especialidad).HasMaxLength(50);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Grafico).HasMaxLength(200);

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Impresion).HasDefaultValueSql("0");

                entity.Property(e => e.Interlocutor).HasColumnType("nchar(6)");

                entity.Property(e => e.Jaula).HasMaxLength(10);

                entity.Property(e => e.Nif).HasMaxLength(14);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Nueva_referencia).HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Operario).HasMaxLength(10);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Pais_origen).HasMaxLength(50);

                entity.Property(e => e.Palet).HasMaxLength(10);

                entity.Property(e => e.Pedido).HasColumnType("nchar(6)");

                entity.Property(e => e.PedidoCliente).HasMaxLength(20);

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Referencia).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_certificada).HasColumnType("nchar(20)");

                entity.Property(e => e.Referencia_original).HasColumnType("nchar(20)");

                entity.Property(e => e.Seccion).HasMaxLength(50);

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_origen).HasColumnType("nchar(3)");

                entity.Property(e => e.Tracking).HasMaxLength(30);

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Etiquetas_rangos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Etiquetas_rangos");

                entity.ToTable("Etiquetas_rangos", "General");

                entity.Property(e => e.Contador).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(100)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Notificado).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Etiquetas_registro>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Etiquetas_registro_1");

                entity.ToTable("Etiquetas_registro", "General");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.NumeroNavigation)
                    .WithMany(p => p.Etiquetas_registro)
                    .HasForeignKey(d => d.Numero)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Etiquetas_registro_Compras_pedidos_detalle");

                entity.HasOne(d => d.RangoNavigation)
                    .WithMany(p => p.Etiquetas_registro)
                    .HasForeignKey(d => d.Rango)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Etiquetas_registro_Etiquetas_rangos");
            });

            modelBuilder.Entity<Evaluacion_clientes>(entity =>
            {
                entity.HasKey(e => e.Cliente)
                    .HasName("PK_Interlocutores_evaluacion");

                entity.ToTable("Evaluacion_clientes", "Calidad");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Comision_media)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comisiones)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_piezas_vendidas)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Financiera_cartera_ventas_impagados_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Financiera_cartera_ventas_impagados_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Indice_abonos)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Indice_facturacion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Indice_impagados)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Indice_rentabilidad)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Numero_envios_agencia_pd).HasDefaultValueSql("0");

                entity.Property(e => e.Numero_envios_agencia_pp).HasDefaultValueSql("0");

                entity.Property(e => e.Numero_envios_rutas).HasDefaultValueSql("0");

                entity.Property(e => e.Numero_piezas_vendidas).HasDefaultValueSql("0");

                entity.Property(e => e.Total_envios_agencia_pd)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_envios_agencia_pp)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_envios_rutas)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Valoracion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_abonos_indice)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_albaranes_abonos_pendientes_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_albaranes_no_facturados_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_albaranes_unidades_exclusivas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_albaranes_unidades_indice)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_albaranes_unidades_no_exclusivas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_albaranes_unidades_vendidas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_abonos_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_avance)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_base_imponible_abonos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_comision_media)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_comision_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_embalajes_total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_portes_coste_real)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_portes_debidos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_portes_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_portes_pagados)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_total_general)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_unidades_abonadas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_facturacion_unidades_embaladas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_nivel_entrega).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_objetivos_indice)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_objetivos_objetivo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_objetivos_prevision)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_pedidos_servidos_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_pedidos_servidos_base_imponible_media)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_pedidos_servidos_numero).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_pedidos_unidades_pedidas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_pedidos_unidades_pendientes).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_pedidos_unidades_servidas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_reclamaciones_indice_abonos)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_reclamaciones_unidades_abolladas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_reclamaciones_unidades_abonadas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_reclamaciones_unidades_chatarra).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_reclamaciones_unidades_devueltas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_reclamaciones_unidades_perfectas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_reclamaciones_unidades_pintadas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_reclamaciones_unidades_reclamadas).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Evaluacion_proveedor>(entity =>
            {
                entity.HasKey(e => e.Proveedor)
                    .HasName("PK_Evaluacion_proveedor");

                entity.ToTable("Evaluacion_proveedor", "Calidad");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaranes_datos_erroneos).HasDefaultValueSql("0");

                entity.Property(e => e.Albaranes_documentacion).HasDefaultValueSql("0");

                entity.Property(e => e.Albaranes_embalaje).HasDefaultValueSql("0");

                entity.Property(e => e.Albaranes_informatizados).HasDefaultValueSql("0");

                entity.Property(e => e.Albaranes_madera_carton_no_retornable).HasDefaultValueSql("0");

                entity.Property(e => e.Albaranes_madera_retornable).HasDefaultValueSql("0");

                entity.Property(e => e.Albaranes_manuales).HasDefaultValueSql("0");

                entity.Property(e => e.Albaranes_metalico_retornable).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_pedidas).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_pedidos).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_servidas).HasDefaultValueSql("0");

                entity.Property(e => e.Indice_defectuosidad).HasDefaultValueSql("0");

                entity.Property(e => e.Indice_documentacion).HasDefaultValueSql("0");

                entity.Property(e => e.Indice_embalaje).HasDefaultValueSql("0");

                entity.Property(e => e.Indice_pendientes).HasDefaultValueSql("0");

                entity.Property(e => e.Indices_plaza_entrega).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo).HasColumnType("nchar(20)");

                entity.Property(e => e.Unidades_enviadas).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_reclamadas).HasDefaultValueSql("0");

                entity.Property(e => e.Valoracion_proveedor).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Evaluacion_proveedor_servicios>(entity =>
            {
                entity.HasKey(e => e.Proveedor)
                    .HasName("PK_Evaluacion_proveedor_servicios");

                entity.ToTable("Evaluacion_proveedor_servicios", "Calidad");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Documentacion_completa).HasDefaultValueSql("0");

                entity.Property(e => e.Documentacion_insuficiente).HasDefaultValueSql("0");

                entity.Property(e => e.Documentacion_suficiente).HasDefaultValueSql("0");

                entity.Property(e => e.Indice_documentacion).HasDefaultValueSql("0");

                entity.Property(e => e.Indice_horas).HasDefaultValueSql("0");

                entity.Property(e => e.Indice_satisfaccion).HasDefaultValueSql("0");

                entity.Property(e => e.Indice_tiempo_respuesta).HasDefaultValueSql("0");

                entity.Property(e => e.Problemas_importantes).HasDefaultValueSql("0");

                entity.Property(e => e.Problemas_menores).HasDefaultValueSql("0");

                entity.Property(e => e.Satisfecho).HasDefaultValueSql("0");

                entity.Property(e => e.Servicio_deficiente).HasDefaultValueSql("0");

                entity.Property(e => e.Servicios_urgentes).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Total_horas).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Evaluacion_transportistas>(entity =>
            {
                entity.HasKey(e => e.Transportista)
                    .HasName("PK_Evaluacion_transportistas");

                entity.ToTable("Evaluacion_transportistas", "Calidad");

                entity.Property(e => e.Transportista).HasColumnType("nchar(6)");

                entity.Property(e => e.Indice_colaboracion).HasDefaultValueSql("0");

                entity.Property(e => e.Indice_plazos_entrega).HasDefaultValueSql("0");

                entity.Property(e => e.Indice_transporte).HasDefaultValueSql("0");

                entity.Property(e => e.Numero_transportes).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Total_horas).HasDefaultValueSql("0");

                entity.Property(e => e.Valoracion_camiones).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Evolucion_costes_lotes_totales>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Evolucion_costes_lotes_totales");

                entity.ToTable("Evolucion_costes_lotes_totales", "Planificacion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.CosteAdquisicionTotalLote).HasColumnType("decimal");

                entity.Property(e => e.CosteAdquisicionUnidad).HasColumnType("decimal");

                entity.Property(e => e.CosteMantenimientoTotalLote).HasColumnType("decimal");

                entity.Property(e => e.CosteMantenimientoUnidad).HasColumnType("decimal");

                entity.Property(e => e.Porcentaje).HasColumnType("nchar(10)");

                entity.Property(e => e.TotalCosteUnidad).HasColumnType("decimal");
            });

            modelBuilder.Entity<Fabricantes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Fabricantes");

                entity.ToTable("Fabricantes", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(4)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Mail).HasMaxLength(30);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Telefono).HasMaxLength(30);
            });

            modelBuilder.Entity<Fases>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Fases");

                entity.ToTable("Fases", "Produccion");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Tipo_fase).HasColumnType("nchar(2)");
            });

            modelBuilder.Entity<Fases_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Tipos_fases");

                entity.ToTable("Fases_tipos", "Produccion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);
            });

            modelBuilder.Entity<Formacion_biblioteca_cursos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formacion_Biblioteca_Cursos");

                entity.ToTable("Formacion_biblioteca_cursos", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Formacion_cursos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formacion_cursos");

                entity.ToTable("Formacion_cursos", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Clasificacion).HasDefaultValueSql("0");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(75);

                entity.Property(e => e.Tipo_curso).HasColumnType("nchar(2)");

                entity.Property(e => e.Tipo_formacion).HasColumnType("nchar(2)");
            });

            modelBuilder.Entity<Formacion_cursos_descripcion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formacion_programa_cabecera");

                entity.ToTable("Formacion_cursos_descripcion", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Coste_curso)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_personal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Curso).HasColumnType("nchar(5)");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Horas_duracion).HasDefaultValueSql("0");

                entity.Property(e => e.Lugar).HasMaxLength(50);

                entity.Property(e => e.Monitor).HasMaxLength(50);

                entity.Property(e => e.Realizado).HasDefaultValueSql("0");

                entity.Property(e => e.Situacion_curso).HasMaxLength(50);

                entity.Property(e => e.Tipo_curso).HasColumnType("nchar(2)");

                entity.Property(e => e.Tipo_formacion).HasColumnType("nchar(2)");

                entity.HasOne(d => d.Tipo_cursoNavigation)
                    .WithMany(p => p.Formacion_cursos_descripcion)
                    .HasForeignKey(d => d.Tipo_curso)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Formacion_cursos_descripcion_Formacion_tipo_curso");

                entity.HasOne(d => d.Tipo_formacionNavigation)
                    .WithMany(p => p.Formacion_cursos_descripcion)
                    .HasForeignKey(d => d.Tipo_formacion)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Formacion_cursos_descripcion_Formacion_tipo_formacion");
            });

            modelBuilder.Entity<Formacion_cursos_obligatorios>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formacion_Cursos_Obligatorios");

                entity.ToTable("Formacion_cursos_obligatorios", "RecursosHumanos");

                entity.Property(e => e.Curso).HasColumnType("nchar(5)");

                entity.Property(e => e.Especialidad).HasColumnType("nchar(2)");

                entity.HasOne(d => d.CursoNavigation)
                    .WithMany(p => p.Formacion_cursos_obligatorios)
                    .HasForeignKey(d => d.Curso)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Formacion_cursos_obligatorios_Formacion_cursos");
            });

            modelBuilder.Entity<Formacion_cursos_personal>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formacion_programa_detalle");

                entity.ToTable("Formacion_cursos_personal", "RecursosHumanos");

                entity.Property(e => e.Curso).HasColumnType("nchar(5)");

                entity.Property(e => e.Departamento).HasColumnType("nchar(3)");

                entity.Property(e => e.Grado_satisfacion).HasColumnType("nchar(30)");

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.HasOne(d => d.CursoNavigation)
                    .WithMany(p => p.Formacion_cursos_personal)
                    .HasForeignKey(d => d.Curso)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Formacion_cursos_personal_Formacion_cursos");
            });

            modelBuilder.Entity<Formacion_ficheros>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Videos");

                entity.ToTable("Formacion_ficheros", "General");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Direccion_web).HasMaxLength(1000);

                entity.Property(e => e.Fichero).HasMaxLength(250);

                entity.Property(e => e.Observaciones).HasColumnType("varchar(max)");
            });

            modelBuilder.Entity<Formacion_plan_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formacion_plan_cabecera");

                entity.ToTable("Formacion_plan_cabecera", "RecursosHumanos");

                entity.Property(e => e.Departamento).HasColumnType("nchar(3)");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_aprobacion).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Formacion_plan_detalle>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formacion_Plan_Detalle");

                entity.ToTable("Formacion_plan_detalle", "RecursosHumanos");

                entity.HasIndex(e => new { e.Cabecera, e.Curso })
                    .HasName("IX_Formacion_Plan_Detalle");

                entity.Property(e => e.Curso).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Formacion_registros>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formacion_registros");

                entity.ToTable("Formacion_registros", "RecursosHumanos");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Codigo_operario).HasColumnType("nchar(4)");

                entity.Property(e => e.Curso).HasColumnType("nchar(5)");

                entity.Property(e => e.Duracion).HasColumnType("numeric");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Grado_satisfacion).HasColumnType("nchar(20)");

                entity.Property(e => e.Impartido).HasMaxLength(50);

                entity.Property(e => e.Registro).HasColumnType("nchar(5)");

                entity.Property(e => e.Tipo_curso).HasMaxLength(50);

                entity.HasOne(d => d.CursoNavigation)
                    .WithMany(p => p.Formacion_registros)
                    .HasForeignKey(d => d.Curso)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Formacion_registros_Formacion_cursos");
            });

            modelBuilder.Entity<Formacion_tipo_curso>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formacion_tipo_curso");

                entity.ToTable("Formacion_tipo_curso", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(30);
            });

            modelBuilder.Entity<Formacion_tipo_formacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formacion_tipo_formacion");

                entity.ToTable("Formacion_tipo_formacion", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(20)");
            });

            modelBuilder.Entity<Formas_pago>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formas_Pago");

                entity.ToTable("Formas_pago", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(4)");

                entity.Property(e => e.Ajuste_vacaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Aplazamiento).HasDefaultValueSql("0");

                entity.Property(e => e.Carencia).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dia_1_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_2_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_3_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_1).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_10).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_11).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_12).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_2).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_3).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_4).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_5).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_6).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_7).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_8).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_pago_9).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_1).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_10).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_11).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_12).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_2).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_3).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_4).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_5).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_6).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_7).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_8).HasDefaultValueSql("0");

                entity.Property(e => e.Dias_aplazamiento_9).HasDefaultValueSql("0");

                entity.Property(e => e.Entrada)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Plazos).HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_1)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_10)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_11)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_12)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_2)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_3)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_4)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_5)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_6)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_7)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_8)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_aplazamiento_9)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_aplazamiento).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_recibos).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Formas_pago_idiomas>(entity =>
            {
                entity.HasKey(e => new { e.Forma_pago, e.Idioma })
                    .HasName("PK_Idiomas_forma_pago");

                entity.ToTable("Formas_pago_idiomas", "Gestion");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Traduccion).HasMaxLength(254);

                entity.HasOne(d => d.Forma_pagoNavigation)
                    .WithMany(p => p.Formas_pago_idiomas)
                    .HasForeignKey(d => d.Forma_pago)
                    .HasConstraintName("FK_Formas_pago_idiomas_Formas_pago");

                entity.HasOne(d => d.IdiomaNavigation)
                    .WithMany(p => p.Formas_pago_idiomas)
                    .HasForeignKey(d => d.Idioma)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Formas_pago_idiomas_Lenguajes");
            });

            modelBuilder.Entity<Formulas_calculo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formulas_calculo");

                entity.ToTable("Formulas_calculo", "General");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(2000)");

                entity.Property(e => e.Nombre).HasColumnType("varchar(50)");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(2000)");
            });

            modelBuilder.Entity<Formulas_calculo_modulos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formulas_calculo_modulos");

                entity.ToTable("Formulas_calculo_modulos", "General");

                entity.Property(e => e.Modulo).HasColumnType("varchar(50)");

                entity.HasOne(d => d.FormulaNavigation)
                    .WithMany(p => p.Formulas_calculo_modulos)
                    .HasForeignKey(d => d.Formula)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Formulas_calculo_modulos_Formulas_calculo");
            });

            modelBuilder.Entity<Formulas_campos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Formulas_campos");

                entity.ToTable("Formulas_campos", "General");

                entity.Property(e => e.Campo).HasMaxLength(50);
            });

            modelBuilder.Entity<Incidencias>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Incidencias");

                entity.ToTable("Incidencias", "General");

                entity.Property(e => e.Clasificacion).HasMaxLength(50);

                entity.Property(e => e.Configuracion).HasColumnType("xml");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Dias_plazo).HasDefaultValueSql("7");

                entity.Property(e => e.Entidad).HasMaxLength(100);

                entity.Property(e => e.Fecha_limite).HasColumnType("smalldatetime");

                entity.Property(e => e.Filtro).HasMaxLength(2000);
            });

            modelBuilder.Entity<Incidencias_usuarios>(entity =>
            {
                entity.HasKey(e => new { e.Codigo, e.Usuario })
                    .HasName("PK_Incidencias_usuarios");

                entity.ToTable("Incidencias_usuarios", "General");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Incoterms>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Incoterms");

                entity.ToTable("Incoterms", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Nombre).HasColumnType("nchar(3)");

                entity.Property(e => e.Puerto_embarque).HasColumnType("nchar(2)");

                entity.Property(e => e.Tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Transporte).HasDefaultValueSql("0");

                entity.HasOne(d => d.Puerto_embarqueNavigation)
                    .WithMany(p => p.Incoterms)
                    .HasForeignKey(d => d.Puerto_embarque)
                    .HasConstraintName("FK_Incoterms_Puertos_embarque");
            });

            modelBuilder.Entity<Informes>(entity =>
            {
                entity.HasKey(e => e.Informe)
                    .HasName("PK_Informes_1");

                entity.ToTable("Informes", "Gestion");

                entity.Property(e => e.Asunto).HasMaxLength(255);

                entity.Property(e => e.Aviso_margenes).HasDefaultValueSql("0");

                entity.Property(e => e.Base_datos).HasMaxLength(25);

                entity.Property(e => e.Body).HasColumnType("ntext");

                entity.Property(e => e.Cabecera).HasDefaultValueSql("1");

                entity.Property(e => e.Consola_impresion).HasDefaultValueSql("0");

                entity.Property(e => e.Copias).HasDefaultValueSql("1");

                entity.Property(e => e.Directorio).HasMaxLength(255);

                entity.Property(e => e.Directorio_server).HasMaxLength(255);

                entity.Property(e => e.Duplex).HasDefaultValueSql("0");

                entity.Property(e => e.Editando).HasDefaultValueSql("0");

                entity.Property(e => e.Filtro).HasDefaultValueSql("1");

                entity.Property(e => e.Generador).HasMaxLength(20);

                entity.Property(e => e.Idioma).HasMaxLength(25);

                entity.Property(e => e.Modulo).HasMaxLength(255);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.Property(e => e.Orden).HasDefaultValueSql("0");

                entity.Property(e => e.Parametros).HasDefaultValueSql("0");

                entity.Property(e => e.Query_defecto).HasDefaultValueSql("1");

                entity.Property(e => e.Titulo).HasMaxLength(100);

                entity.Property(e => e.Traducir).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Informes_formatos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Informes_formatos");

                entity.ToTable("Informes_formatos", "Gestion");

                entity.HasOne(d => d.InformeNavigation)
                    .WithMany(p => p.Informes_formatos)
                    .HasForeignKey(d => d.Informe)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Informes_formatos_Informes");
            });

            modelBuilder.Entity<Interlocutores>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores");

                entity.ToTable("Interlocutores", "Gestion");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Bloqueo_informacion).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_operaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Clasificacion).HasColumnType("nchar(2)");

                entity.Property(e => e.Clave1).HasMaxLength(20);

                entity.Property(e => e.Clave2).HasMaxLength(20);

                entity.Property(e => e.Clave3).HasMaxLength(20);

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Fecha_alta).HasColumnType("smalldatetime");

                entity.Property(e => e.Ftp).HasMaxLength(100);

                entity.Property(e => e.Grafico).HasMaxLength(50);

                entity.Property(e => e.Horario_descarga1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_descarga2).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina2).HasColumnType("nchar(5)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Interlocutor).HasColumnType("nchar(6)");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Internet_acceso).HasDefaultValueSql("0");

                entity.Property(e => e.Internet_grupo).HasColumnType("nchar(5)");

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Telefono3).HasMaxLength(30);

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Vacaciones_final).HasColumnType("nchar(5)");

                entity.Property(e => e.Vacaciones_inicio).HasColumnType("nchar(5)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);

                entity.Property(e => e.Zona).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Interlocutores_clasificacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_clasificacion");

                entity.ToTable("Interlocutores_clasificacion", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Iso_acciones_correctivas>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Iso_acciones_correctivas");

                entity.ToTable("Iso_acciones_correctivas", "Calidad");

                entity.Property(e => e.AC_AP).HasColumnType("text");

                entity.Property(e => e.AC_AP_descripcion).HasColumnType("varchar(30)");

                entity.Property(e => e.A_realizadas).HasColumnType("text");

                entity.Property(e => e.Accion_descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.Accion_propuesta).HasColumnType("text");

                entity.Property(e => e.Accion_propuesta_descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.Afecta_descripcion).HasColumnType("varchar(25)");

                entity.Property(e => e.Causa_descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.Causa_objetivo).HasColumnType("text");

                entity.Property(e => e.Cierre).HasColumnType("char(15)");

                entity.Property(e => e.Fecha_apertura).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_cierre).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio_AC).HasColumnType("smalldatetime");

                entity.Property(e => e.Firma_VB).HasColumnType("varchar(100)");

                entity.Property(e => e.Firma_jefe).HasColumnType("varchar(100)");

                entity.Property(e => e.Firma_responsable).HasColumnType("varchar(100)");

                entity.Property(e => e.Foto).HasColumnType("varchar(100)");

                entity.Property(e => e.Horas).HasColumnType("numeric");

                entity.Property(e => e.Material).HasColumnType("numeric");

                entity.Property(e => e.Motivo_descripcion).HasColumnType("varchar(20)");

                entity.Property(e => e.Motivo_tipo).HasColumnType("varchar(20)");

                entity.Property(e => e.Propuesta).HasColumnType("varchar(30)");

                entity.Property(e => e.Referencia).HasColumnType("varchar(20)");

                entity.Property(e => e.Referencia_descripcion).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Iso_auditorias>(entity =>
            {
                entity.HasKey(e => e.Numero_auditoria)
                    .HasName("PK_Iso_auditorias");

                entity.ToTable("Iso_auditorias", "Calidad");

                entity.Property(e => e.Numero_auditoria).HasColumnType("varchar(7)");

                entity.Property(e => e.AA_CC).HasColumnType("text");

                entity.Property(e => e.Anexo).HasColumnType("text");

                entity.Property(e => e.Capitulos).HasColumnType("varchar(50)");

                entity.Property(e => e.Colabora).HasColumnType("varchar(100)");

                entity.Property(e => e.Comprobaciones).HasColumnType("text");

                entity.Property(e => e.Departamento).HasColumnType("varchar(50)");

                entity.Property(e => e.Fecha_auditoria).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_comprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Firma_colabora).HasColumnType("varchar(30)");

                entity.Property(e => e.Firma_comprobacion).HasColumnType("varchar(30)");

                entity.Property(e => e.Firma_realiza).HasColumnType("varchar(30)");

                entity.Property(e => e.Hora_final).HasColumnType("varchar(5)");

                entity.Property(e => e.Hora_inicio).HasColumnType("varchar(5)");

                entity.Property(e => e.No_conformidad).HasColumnType("text");

                entity.Property(e => e.Paginas).HasColumnType("char(3)");

                entity.Property(e => e.Plazo).HasColumnType("smalldatetime");

                entity.Property(e => e.Realizada_por).HasColumnType("varchar(100)");

                entity.Property(e => e.Responsable).HasColumnType("varchar(30)");
            });

            modelBuilder.Entity<Iso_causas_queja>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Calidad_iso_causas_queja");

                entity.ToTable("Iso_causas_queja", "Calidad");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Iso_no_conformidades>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Calidad_Iso_No_Conformidades");

                entity.ToTable("Iso_no_conformidades", "Calidad");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Articulo_erroneo).HasDefaultValueSql("0");

                entity.Property(e => e.Calidad).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_entrega).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_informe).HasColumnType("smalldatetime");

                entity.Property(e => e.Firma_responsable).HasColumnType("nchar(4)");

                entity.Property(e => e.Otros).HasDefaultValueSql("0");

                entity.Property(e => e.Personal).HasColumnType("nchar(4)");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Realizacion_AACC).HasDefaultValueSql("0");

                entity.Property(e => e.Rechazada_entregada).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Iso_reclamaciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Calidad_Iso_Reclamaciones");

                entity.ToTable("Iso_reclamaciones", "Calidad");

                entity.Property(e => e.Codigo).HasColumnType("nchar(10)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Causa).HasColumnType("nchar(2)");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Contacto).HasColumnType("nchar(4)");

                entity.Property(e => e.Fecha_queja).HasColumnType("smalldatetime");

                entity.Property(e => e.Responsable).HasColumnType("nchar(4)");

                entity.Property(e => e.Solucionado).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_queja).HasColumnType("nchar(15)");
            });

            modelBuilder.Entity<Ivas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ivas");

                entity.ToTable("Ivas", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Adquisicion_intracomunitaria).HasDefaultValueSql("0");

                entity.Property(e => e.Categoria).HasColumnType("nchar(3)");

                entity.Property(e => e.Deducible_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Igic).HasDefaultValueSql("0");

                entity.Property(e => e.Impuesto_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Impuesto_porcentaje_libro_iva)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Iva_contable)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nombre).HasMaxLength(80);

                entity.Property(e => e.Recargo_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_porcentaje_libro_iva)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Subcuenta).HasColumnType("nchar(20)");

                entity.HasOne(d => d.CategoriaNavigation)
                    .WithMany(p => p.Ivas)
                    .HasForeignKey(d => d.Categoria)
                    .HasConstraintName("FK_Ivas_Ivas_categorias");
            });

            modelBuilder.Entity<Ivas_categorias>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ivas_categorias");

                entity.ToTable("Ivas_categorias", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Habilitado).HasDefaultValueSql("1");

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<Jaulas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Jaulas");

                entity.ToTable("Jaulas", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(10)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Tipo).HasColumnType("nchar(25)");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Jaulas)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("FK_Jaulas_Utiles_jaulas");
            });

            modelBuilder.Entity<Jaulas_movimientos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_jaulas");

                entity.ToTable("Jaulas_movimientos", "Logistica");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Codigo_direccion).HasDefaultValueSql("0");

                entity.Property(e => e.Contenedor).HasColumnType("nchar(14)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Jaula).HasColumnType("nchar(10)");

                entity.Property(e => e.Matricula).HasColumnType("nchar(10)");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Jaulas_movimientos)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Jaulas_movimientos_Clientes");

                entity.HasOne(d => d.JaulaNavigation)
                    .WithMany(p => p.Jaulas_movimientos)
                    .HasForeignKey(d => d.Jaula)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Jaulas_movimientos_Jaulas");
            });

            modelBuilder.Entity<Jaulas_stocks>(entity =>
            {
                entity.HasKey(e => e.Jaula)
                    .HasName("PK_Jaulas_stocks_1");

                entity.ToTable("Jaulas_stocks", "Logistica");

                entity.Property(e => e.Jaula).HasColumnType("nchar(10)");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Contenedor).HasColumnType("nchar(14)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_notificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Matricula).HasColumnType("nchar(10)");

                entity.Property(e => e.Notificacion).HasDefaultValueSql("0");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Jaulas_stocks)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Jaulas_stocks_Interlocutores");
            });

            modelBuilder.Entity<Lanzamientos>(entity =>
            {
                entity.HasKey(e => e.Lanzamiento)
                    .HasName("PK_Lanzamientos_1");

                entity.ToTable("Lanzamientos", "Produccion");

                entity.Property(e => e.Codigo_proyecto).HasColumnType("varchar(20)");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(200)");

                entity.Property(e => e.Descripcion_ampliada).HasColumnType("varchar(4000)");

                entity.Property(e => e.Descripcion_ampliada_2).HasColumnType("ntext");

                entity.Property(e => e.Descripcion_partida).HasColumnType("varchar(40)");

                entity.Property(e => e.Descripcion_proyecto).HasColumnType("varchar(40)");

                entity.Property(e => e.Descripcion_subproyecto).HasColumnType("varchar(40)");

                entity.Property(e => e.Fecha_alta).HasColumnType("datetime");

                entity.Property(e => e.Fecha_cierre).HasColumnType("datetime");

                entity.Property(e => e.Fecha_lanzamiento).HasColumnType("datetime");

                entity.Property(e => e.Fecha_previa_fin_fabricacion).HasColumnType("datetime");

                entity.Property(e => e.Fecha_previa_inicio_fabricacion).HasColumnType("datetime");

                entity.Property(e => e.Planta).HasColumnType("varchar(8)");
            });

            modelBuilder.Entity<Lanzamientos_reserva>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Lanzamiento_reserva");

                entity.ToTable("Lanzamientos_reserva", "Produccion");

                entity.HasIndex(e => e.Lanzamiento)
                    .HasName("Idx_Lanzamiento");

                entity.HasIndex(e => e.Procesada)
                    .HasName("Idx_Procesada");

                entity.HasIndex(e => e.Simulacion)
                    .HasName("Idx_Simulacion");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Control).HasDefaultValueSql("1");

                entity.Property(e => e.Fecha_alta)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Hijo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Nivel).HasDefaultValueSql("0");

                entity.Property(e => e.Orden).HasDefaultValueSql("0");

                entity.Property(e => e.Padre)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Procesada).HasDefaultValueSql("0");

                entity.HasOne(d => d.LanzamientoNavigation)
                    .WithMany(p => p.Lanzamientos_reserva)
                    .HasForeignKey(d => d.Lanzamiento)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Lanzamientos_reserva_Lanzamientos");
            });

            modelBuilder.Entity<Lenguajes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Lenguajes");

                entity.ToTable("Lenguajes", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(10)");
            });

            modelBuilder.Entity<Lista_materiales>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Lista_materiales_1");

                entity.ToTable("Lista_materiales", "Produccion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Articulo_padre).HasColumnType("nchar(20)");

                entity.Property(e => e.Bruto_alto).HasMaxLength(6);

                entity.Property(e => e.Bruto_ancho).HasMaxLength(6);

                entity.Property(e => e.Bruto_largo).HasMaxLength(6);

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Fecha_ultima_modificacion).HasColumnType("datetime");

                entity.Property(e => e.Indice_modificacion_externo).HasColumnType("nchar(4)");

                entity.Property(e => e.Indice_modificacion_interno).HasColumnType("nchar(4)");

                entity.Property(e => e.Lista).HasColumnType("nchar(20)");

                entity.Property(e => e.Marca).HasMaxLength(50);

                entity.Property(e => e.Material).HasMaxLength(50);

                entity.Property(e => e.Norma).HasMaxLength(50);

                entity.Property(e => e.Prioridad).HasColumnType("nchar(1)");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(1)");
            });

            modelBuilder.Entity<Lista_materiales_historico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Lista_materiales_historico_1");

                entity.ToTable("Lista_materiales_historico", "Produccion");

                entity.Property(e => e.Accion).HasColumnType("nchar(10)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Articulo_padre).HasColumnType("nchar(20)");

                entity.Property(e => e.Bruto_alto).HasMaxLength(6);

                entity.Property(e => e.Bruto_ancho).HasMaxLength(6);

                entity.Property(e => e.Bruto_largo).HasMaxLength(6);

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Fecha_ultima_modificacion).HasColumnType("datetime");

                entity.Property(e => e.Indice_modificacion_externo).HasColumnType("nchar(4)");

                entity.Property(e => e.Indice_modificacion_interno).HasColumnType("nchar(4)");

                entity.Property(e => e.Lista).HasColumnType("nchar(20)");

                entity.Property(e => e.Marca).HasMaxLength(50);

                entity.Property(e => e.Material).HasMaxLength(50);

                entity.Property(e => e.Norma).HasMaxLength(50);

                entity.Property(e => e.Prioridad).HasColumnType("nchar(1)");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(1)");
            });

            modelBuilder.Entity<Lista_materiales_modificaciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Lista_materiales_modificaciones");

                entity.ToTable("Lista_materiales_modificaciones", "Produccion");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Coste_real)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasColumnType("nchar(10)");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.Horas_ajuste_estimadas)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Horas_ajuste_real)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Horas_cad_estimadas)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Horas_cad_real)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Horas_maquinas_2d_estimadas)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Horas_maquinas_2d_real)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Horas_maquinas_3d_estimadas)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Horas_maquinas_3d_real)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Horas_oficina_tecnica_estimadas)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Horas_oficina_tecnica_real)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Lista).HasColumnType("nchar(20)");

                entity.Property(e => e.Materiales_estimados)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Materiales_real)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasColumnType("nchar(20)");

                entity.Property(e => e.Tratamientos_estimados)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tratamientos_real)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Valoracion_economica_estimada)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Lista_materiales_modificaciones_fotos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Lista_materiales_modificaciones_fotos");

                entity.ToTable("Lista_materiales_modificaciones_fotos", "Produccion");
            });

            modelBuilder.Entity<Mails_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Mails_tipos");

                entity.ToTable("Mails_tipos", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Mantenimiento_detalles_averias>(entity =>
            {
                entity.HasKey(e => e.Ind)
                    .HasName("PK_Mantenimiento_detalles_averias");

                entity.ToTable("Mantenimiento_detalles_averias", "Carroceria");

                entity.Property(e => e.Ind).ValueGeneratedNever();

                entity.Property(e => e.Detalle_averia).HasColumnType("ntext");

                entity.Property(e => e.Equipo_instalacion).HasColumnType("char(4)");

                entity.Property(e => e.Fecha_averia).HasColumnType("smalldatetime");

                entity.Property(e => e.Operario).HasColumnType("char(4)");

                entity.Property(e => e.Titulo_averia).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Mantenimiento_hojas_trabajo_cabecera>(entity =>
            {
                entity.HasKey(e => e.Ind)
                    .HasName("PK_Mantenimiento_hojas_trabajo_cabecera");

                entity.ToTable("Mantenimiento_hojas_trabajo_cabecera", "Carroceria");

                entity.Property(e => e.Fecha_hoja).HasColumnType("smalldatetime");

                entity.Property(e => e.Horas_extras).HasDefaultValueSql("0");

                entity.Property(e => e.Horas_extras_festivas).HasDefaultValueSql("0");

                entity.Property(e => e.Horas_extras_festivas_nocturnas).HasDefaultValueSql("0");

                entity.Property(e => e.Horas_extras_nocturnas).HasDefaultValueSql("0");

                entity.Property(e => e.Horas_ordinarias).HasDefaultValueSql("0");

                entity.Property(e => e.Horas_ordinarias_festivas).HasDefaultValueSql("0");

                entity.Property(e => e.Horas_ordinarias_festivas_nocturnas).HasDefaultValueSql("0");

                entity.Property(e => e.Horas_ordinarias_nocturnas).HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Operario).HasColumnType("char(4)");

                entity.Property(e => e.Traspasada).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Mantenimiento_hojas_trabajo_detalle>(entity =>
            {
                entity.HasKey(e => e.Clave)
                    .HasName("PK_Mantenimiento_hojas_trabajo_detalle");

                entity.ToTable("Mantenimiento_hojas_trabajo_detalle", "Carroceria");

                entity.Property(e => e.Clave).ValueGeneratedNever();

                entity.Property(e => e.Area).HasColumnType("char(2)");

                entity.Property(e => e.Cierre_OT).HasDefaultValueSql("0");

                entity.Property(e => e.Codigo_averia).HasColumnType("varchar(20)");

                entity.Property(e => e.Descripcion_intervencion).HasColumnType("varchar(300)");

                entity.Property(e => e.Detalle).HasColumnType("char(2)");

                entity.Property(e => e.Equipo_instalacion).HasColumnType("char(4)");

                entity.Property(e => e.Fecha_intervencion).HasColumnType("smalldatetime");

                entity.Property(e => e.Horas).HasDefaultValueSql("0");

                entity.Property(e => e.Ind).ValueGeneratedOnAdd();

                entity.Property(e => e.Intervencion_exterior).HasColumnType("char(2)");

                entity.Property(e => e.Numero_OT).HasColumnType("char(10)");

                entity.Property(e => e.Parada).HasColumnType("char(2)");

                entity.Property(e => e.Repuestos).HasColumnType("char(2)");

                entity.Property(e => e.Sistemas).HasColumnType("char(50)");

                entity.Property(e => e.Tipo_mantenimiento).HasColumnType("varchar(25)");

                entity.Property(e => e.Traspasada).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Mantenimiento_lanzamientos_cabecera>(entity =>
            {
                entity.HasKey(e => e.Iden)
                    .HasName("PK_Mantenimiento_lanzamientos_cabecera");

                entity.ToTable("Mantenimiento_lanzamientos_cabecera", "Carroceria");

                entity.Property(e => e.Aplicacion_gama).HasColumnType("char(30)");

                entity.Property(e => e.Descripcion_gama).HasColumnType("varchar(60)");

                entity.Property(e => e.Ejecutado).HasColumnType("char(4)");

                entity.Property(e => e.Equipo_instalacion).HasColumnType("char(4)");

                entity.Property(e => e.Fecha_ejecucion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_lanzamiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Seccion).HasColumnType("char(25)");
            });

            modelBuilder.Entity<Mantenimiento_lanzamientos_detalle>(entity =>
            {
                entity.HasKey(e => e.Clave)
                    .HasName("PK_Mantenimiento_lanzamientos_detalle");

                entity.ToTable("Mantenimiento_lanzamientos_detalle", "Carroceria");

                entity.Property(e => e.Descripcion_fase).HasColumnType("text");

                entity.Property(e => e.Fecha_lanzamiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Horas)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Mantenimiento_preventivo_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Mantenimiento_gamas_cabecera");

                entity.ToTable("Mantenimiento_preventivo_cabecera", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(60);
            });

            modelBuilder.Entity<Mantenimiento_preventivo_detalle>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Mantenimiento_mantenimiento_preventivo_detalle");

                entity.ToTable("Mantenimiento_preventivo_detalle", "Carroceria");

                entity.Property(e => e.Fase).HasColumnType("nchar(3)");

                entity.Property(e => e.Horas_maquina).HasDefaultValueSql("0");

                entity.Property(e => e.Periodicidad).HasColumnType("nchar(2)");

                entity.Property(e => e.Preventivo)
                    .IsRequired()
                    .HasColumnType("nchar(3)");
            });

            modelBuilder.Entity<Mantenimiento_solicitud_asistencia_tecnica>(entity =>
            {
                entity.HasKey(e => e.Iden)
                    .HasName("PK_Mantenimiento_solicitud_asistencia_tecnica");

                entity.ToTable("Mantenimiento_solicitud_asistencia_tecnica", "Carroceria");

                entity.Property(e => e.Coste).HasDefaultValueSql("0");

                entity.Property(e => e.Empresa_externa).HasColumnType("varchar(50)");

                entity.Property(e => e.Fecha_intervencion).HasColumnType("smalldatetime");

                entity.Property(e => e.Horas).HasDefaultValueSql("0");

                entity.Property(e => e.Maquina_instalacion).HasColumnType("char(4)");

                entity.Property(e => e.Numero_documento).HasColumnType("nchar(15)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Operario).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<Mantenimiento_solicitudes>(entity =>
            {
                entity.HasKey(e => e.Ind)
                    .HasName("PK_Manteniento_solicitudes");

                entity.ToTable("Mantenimiento_solicitudes", "Carroceria");

                entity.Property(e => e.Descripcion_averia).HasColumnType("text");

                entity.Property(e => e.Fecha_propuesta).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_solicitud).HasColumnType("smalldatetime");

                entity.Property(e => e.Hora).HasColumnType("datetime");

                entity.Property(e => e.Maquina).HasColumnType("char(4)");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Prioridad).HasColumnType("char(25)");

                entity.Property(e => e.Responsable).HasColumnType("char(4)");

                entity.Property(e => e.Seccion).HasColumnType("char(30)");

                entity.Property(e => e.Solicitante).HasColumnType("char(4)");

                entity.Property(e => e.Tipo_averia).HasColumnType("char(30)");
            });

            modelBuilder.Entity<Mantenimiento_tipo_maestro>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Mantenimiento_tipo_maestro");

                entity.ToTable("Mantenimiento_tipo_maestro", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Maquinas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Maquinas");

                entity.ToTable("Maquinas", "Produccion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Abreviatura).HasColumnType("nchar(3)");

                entity.Property(e => e.Alto).HasDefaultValueSql("0");

                entity.Property(e => e.Ancho).HasDefaultValueSql("0");

                entity.Property(e => e.Automantenimiento).HasDefaultValueSql("0");

                entity.Property(e => e.Auxiliares)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro).HasColumnType("nchar(6)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Consumos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Estructuras)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fabricante).HasColumnType("nchar(40)");

                entity.Property(e => e.Familia).HasColumnType("nchar(2)");

                entity.Property(e => e.Fecha_fabricacion).HasColumnType("datetime");

                entity.Property(e => e.Fecha_fin_garantia).HasColumnType("datetime");

                entity.Property(e => e.Fecha_instalacion).HasColumnType("datetime");

                entity.Property(e => e.Grafico).HasMaxLength(100);

                entity.Property(e => e.Horas_disponibles)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Inmuebles)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Largo).HasDefaultValueSql("0");

                entity.Property(e => e.Mantenimiento_predictivo).HasDefaultValueSql("0");

                entity.Property(e => e.Mantenimiento_preventivo).HasDefaultValueSql("0");

                entity.Property(e => e.Marca).HasMaxLength(100);

                entity.Property(e => e.Mo_operador)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Mo_operario)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Modelo).HasMaxLength(50);

                entity.Property(e => e.Numero_serie).HasColumnType("nchar(30)");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Potencia_electrica).HasDefaultValueSql("0");

                entity.Property(e => e.Prensas)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Seccion).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(2)");

                entity.Property(e => e.Total_maquina)
                    .HasColumnType("money")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<Maquinas_centros_trabajo_relacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Codigo");

                entity.ToTable("Maquinas_centros_trabajo_relacion", "Produccion");

                entity.Property(e => e.Centro)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Maquina)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.HasOne(d => d.CentroNavigation)
                    .WithMany(p => p.Maquinas_centros_trabajo_relacion)
                    .HasForeignKey(d => d.Centro)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Centros_maquinas_Centros");
            });

            modelBuilder.Entity<Maquinas_componentes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Maquinas_componentes");

                entity.ToTable("Maquinas_componentes", "Produccion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(14)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Maquinas_familias>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Maquinas_tipos");

                entity.ToTable("Maquinas_familias", "Produccion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("varchar(50)");

                entity.Property(e => e.Observaciones).HasColumnType("text");
            });

            modelBuilder.Entity<Maquinas_grupos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Maquinas_especificaciones_tecnicas");

                entity.ToTable("Maquinas_grupos", "Produccion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Maquinas_grupos_componentes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Maquinas_sistemas");

                entity.ToTable("Maquinas_grupos_componentes", "Produccion");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Componente).HasColumnType("nchar(6)");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Sistema).HasColumnType("nchar(11)");
            });

            modelBuilder.Entity<Maquinas_grupos_relacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Maquinas_Grupos_relacion");

                entity.ToTable("Maquinas_grupos_relacion", "Produccion");

                entity.HasIndex(e => new { e.Grupo, e.Maquina })
                    .HasName("IX_Maquinas_Grupos_relacion");

                entity.Property(e => e.Grupo)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.Maquina)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.HasOne(d => d.MaquinaNavigation)
                    .WithMany(p => p.Maquinas_grupos_relacion)
                    .HasForeignKey(d => d.Maquina)
                    .HasConstraintName("FK_Maquinas_grupos_relacion_Maquinas");
            });

            modelBuilder.Entity<Maquinas_preventivo_relacion>(entity =>
            {
                entity.HasKey(e => new { e.Preventivo, e.Maquina })
                    .HasName("PK_Maquinas_preventivo_relacion");

                entity.ToTable("Maquinas_preventivo_relacion", "Produccion");

                entity.Property(e => e.Preventivo).HasColumnType("nchar(3)");

                entity.Property(e => e.Maquina).HasColumnType("nchar(5)");

                entity.HasOne(d => d.MaquinaNavigation)
                    .WithMany(p => p.Maquinas_preventivo_relacion)
                    .HasForeignKey(d => d.Maquina)
                    .HasConstraintName("FK_Maquinas_preventivo_relacion_Maquinas");
            });

            modelBuilder.Entity<Maquinas_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Tipos_Maquinas");

                entity.ToTable("Maquinas_tipos", "Produccion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);
            });

            modelBuilder.Entity<Marcas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Marcas");

                entity.ToTable("Marcas", "Matriceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Materiales>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Materiales");

                entity.ToTable("Materiales", "Matriceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Normas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Normas");

                entity.ToTable("Normas", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Norma).HasMaxLength(20);
            });

            modelBuilder.Entity<Observaciones_notificaciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Observaciones_notificaciones");

                entity.ToTable("Observaciones_notificaciones", "General");

                entity.Property(e => e.TipoDocumento).HasColumnType("nchar(20)");
            });

            modelBuilder.Entity<Operaciones_auxiliares>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Operaciones_auxiliares");

                entity.ToTable("Operaciones_auxiliares", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Ordenes_trabajo>(entity =>
            {
                entity.HasKey(e => e.Orden_trabajo)
                    .HasName("PK_Ordenes_trabajo");

                entity.ToTable("Ordenes_trabajo", "Produccion");

                entity.HasIndex(e => e.Centro_trabajo)
                    .HasName("Idx_CentroTrabajo");

                entity.HasIndex(e => e.Estado)
                    .HasName("Idx_Estado");

                entity.HasIndex(e => e.Fecha_alta)
                    .HasName("Idx_FechaAlta");

                entity.HasIndex(e => e.Fecha_final_trabajo)
                    .HasName("Idx_FechaFinalTrabajo");

                entity.HasIndex(e => e.Fecha_inicio_trabajo)
                    .HasName("Idx_FechaInicioTrabajo");

                entity.HasIndex(e => e.Lanzamiento)
                    .HasName("Idx_Lanzamiento");

                entity.HasIndex(e => e.Proyecto)
                    .HasName("Idx_Proyecto");

                entity.HasIndex(e => e.Simulacion)
                    .HasName("Idx_Simulacion");

                entity.HasIndex(e => e.Tipo)
                    .HasName("Idx_Tipo");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad_buena)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_defectuosa)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_fabricar)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_pendiente)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_total)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(6)");

                entity.Property(e => e.Centro_grupo).HasColumnType("nchar(6)");

                entity.Property(e => e.Centro_trabajo).HasColumnType("nchar(6)");

                entity.Property(e => e.Centro_trabajo_destino).HasColumnType("nchar(6)");

                entity.Property(e => e.Completado)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Control).HasDefaultValueSql("1");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Estado).HasDefaultValueSql("3");

                entity.Property(e => e.Fecha_alta)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_final_trabajo).HasColumnType("datetime");

                entity.Property(e => e.Fecha_inicio_trabajo).HasColumnType("datetime");

                entity.Property(e => e.Fecha_requerida).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_ultima_transaccion).HasColumnType("smalldatetime");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Operarios).HasDefaultValueSql("0");

                entity.Property(e => e.Orden).HasDefaultValueSql("0");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("3");

                entity.Property(e => e.Procesar).HasDefaultValueSql("0");

                entity.Property(e => e.Tiempo_estimado).HasDefaultValueSql("0");

                entity.Property(e => e.Tiempo_preparacion).HasDefaultValueSql("0");

                entity.Property(e => e.Tiempo_real).HasDefaultValueSql("0");

                entity.Property(e => e.Tiempo_total).HasDefaultValueSql("0");

                entity.Property(e => e.Traspasado).HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Ordenes_trabajo)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Ordenes_trabajo_Articulos");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Ordenes_trabajo)
                    .HasForeignKey(d => d.Estado)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ordenes_trabajo_Ordenes_trabajo_estados");

                entity.HasOne(d => d.LanzamientoNavigation)
                    .WithMany(p => p.Ordenes_trabajo)
                    .HasForeignKey(d => d.Lanzamiento)
                    .HasConstraintName("FK_Ordenes_trabajo_Lanzamientos");

                entity.HasOne(d => d.Orden_trabajo_padreNavigation)
                    .WithMany(p => p.InverseOrden_trabajo_padreNavigation)
                    .HasForeignKey(d => d.Orden_trabajo_padre)
                    .HasConstraintName("FK_Ordenes_trabajo_Ordenes_trabajo");

                entity.HasOne(d => d.PrioridadNavigation)
                    .WithMany(p => p.Ordenes_trabajo)
                    .HasForeignKey(d => d.Prioridad)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ordenes_trabajo_Ordenes_trabajo_prioridad");

                entity.HasOne(d => d.SimulacionNavigation)
                    .WithMany(p => p.Ordenes_trabajo)
                    .HasForeignKey(d => d.Simulacion)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ordenes_trabajo_Simulaciones1");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Ordenes_trabajo)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("FK_Ordenes_trabajo_Ordenes_trabajo_tipos");
            });

            modelBuilder.Entity<Ordenes_trabajo_estados>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ordenes_trabajo_tipo");

                entity.ToTable("Ordenes_trabajo_estados", "Produccion");

                entity.Property(e => e.Color).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Ordenes_trabajo_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ordenes_trabajo_tipos");

                entity.ToTable("Ordenes_trabajo_tipos", "Produccion");

                entity.Property(e => e.Color).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal");

                entity.ToTable("Personal", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Absentismo).HasDefaultValueSql("0");

                entity.Property(e => e.Activo).HasDefaultValueSql("1");

                entity.Property(e => e.Apellido1).HasMaxLength(50);

                entity.Property(e => e.Apellido2).HasMaxLength(50);

                entity.Property(e => e.CPais).HasColumnType("nchar(3)");

                entity.Property(e => e.Candidato).HasDefaultValueSql("0");

                entity.Property(e => e.Categoria).HasColumnType("nchar(2)");

                entity.Property(e => e.Centro_preferente).HasColumnType("nchar(4)");

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Departamento).HasColumnType("nchar(3)");

                entity.Property(e => e.Destino).HasColumnType("nchar(2)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasColumnType("nchar(2)");

                entity.Property(e => e.En_cartera).HasDefaultValueSql("0");

                entity.Property(e => e.Especialidad).HasColumnType("nchar(2)");

                entity.Property(e => e.Evaluacion).HasColumnType("nchar(1)");

                entity.Property(e => e.Fecha_fin_contrato).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_ingreso).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_nacimiento).HasColumnType("datetime");

                entity.Property(e => e.Filtro).HasDefaultValueSql("0");

                entity.Property(e => e.Grafico).HasMaxLength(100);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Lugar_nacimiento).HasMaxLength(50);

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Nombre_completo)
                    .IsRequired()
                    .HasMaxLength(152)
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Numero_tarjeta_reloj).HasMaxLength(10);

                entity.Property(e => e.Pais).HasMaxLength(35);

                entity.Property(e => e.Pais_nacimiento).HasMaxLength(35);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Presencia).HasDefaultValueSql("0");

                entity.Property(e => e.Prima_Produccion).HasColumnType("nchar(3)");

                entity.Property(e => e.Prima_asistencia_puntualidad).HasColumnType("nchar(3)");

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Provincia_nacimiento).HasMaxLength(50);

                entity.Property(e => e.Responsable).HasColumnType("nchar(5)");

                entity.Property(e => e.Seguridad_social_codigo_contrato).HasColumnType("nchar(3)");

                entity.Property(e => e.Seguridad_social_epigrafe).HasColumnType("nchar(3)");

                entity.Property(e => e.Seguridad_social_grupo_cotizacion).HasColumnType("nchar(2)");

                entity.Property(e => e.Seguridad_social_numero).HasColumnType("nchar(14)");

                entity.Property(e => e.Sexo).HasColumnType("nchar(1)");

                entity.Property(e => e.Subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Turno).HasColumnType("nchar(2)");

                entity.Property(e => e.Voip1).HasMaxLength(50);

                entity.Property(e => e.Voip2).HasMaxLength(50);

                entity.HasOne(d => d.DepartamentoNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.Departamento)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Personal_Personal_departamentos");

                entity.HasOne(d => d.EmpresaNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.Empresa)
                    .HasConstraintName("FK_Personal_Personal_empresas");

                entity.HasOne(d => d.EspecialidadNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.Especialidad)
                    .HasConstraintName("FK_Personal_Personal_especialidades");

                entity.HasOne(d => d.Prima_ProduccionNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.Prima_Produccion)
                    .HasConstraintName("FK_Personal_Personal_prima_produccion");

                entity.HasOne(d => d.Prima_asistencia_puntualidadNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.Prima_asistencia_puntualidad)
                    .HasConstraintName("FK_Personal_Personal_prima_asistencia_puntualidad");

                entity.HasOne(d => d.Seguridad_social_epigrafeNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.Seguridad_social_epigrafe)
                    .HasConstraintName("FK_Personal_Personal_seguridad_social_epigrafes");

                entity.HasOne(d => d.Seguridad_social_grupo_cotizacionNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.Seguridad_social_grupo_cotizacion)
                    .HasConstraintName("FK_Personal_Personal_grupo_cotizacion");

                entity.HasOne(d => d.TurnoNavigation)
                    .WithMany(p => p.Personal)
                    .HasForeignKey(d => d.Turno)
                    .HasConstraintName("FK_Personal_Personal_turnos");
            });

            modelBuilder.Entity<Personal_absentismo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Absentismo");

                entity.ToTable("Personal_absentismo", "RecursosHumanos");

                entity.HasIndex(e => new { e.Personal, e.Ejercicio, e.Mes })
                    .HasName("IX_Absentismo")
                    .IsUnique();

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Horas_baja_accidente).HasDefaultValueSql("0");

                entity.Property(e => e.Horas_baja_enfermedad).HasDefaultValueSql("0");

                entity.Property(e => e.Horas_posibles).HasDefaultValueSql("0");

                entity.Property(e => e.Mes)
                    .IsRequired()
                    .HasColumnType("nchar(2)");

                entity.Property(e => e.Personal)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.HasOne(d => d.PersonalNavigation)
                    .WithMany(p => p.Personal_absentismo)
                    .HasForeignKey(d => d.Personal)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Personal_Absentismo_Personal");
            });

            modelBuilder.Entity<Personal_accidentes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_accidentes");

                entity.ToTable("Personal_accidentes", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Accidente_ampliacion_desencadenante_agente).HasColumnType("nchar(8)");

                entity.Property(e => e.Accidente_ampliacion_desencadenante_desviacion).HasColumnType("nchar(2)");

                entity.Property(e => e.Accidente_ampliacion_forma_lesion).HasColumnType("nchar(2)");

                entity.Property(e => e.Accidente_ampliacion_objeto).HasColumnType("nchar(8)");

                entity.Property(e => e.Accidente_ampliacion_objeto_implicado_codigo).HasColumnType("nchar(8)");

                entity.Property(e => e.Accidente_ampliacion_proceso_tipo_trabajo).HasColumnType("nchar(2)");

                entity.Property(e => e.Accidente_ampliacion_tarea_especifica).HasColumnType("nchar(2)");

                entity.Property(e => e.Accidente_ampliacion_tipo_lugar).HasColumnType("nchar(3)");

                entity.Property(e => e.Accidente_centro_CIF_contrata).HasColumnType("nchar(14)");

                entity.Property(e => e.Accidente_centro_CIF_ett).HasColumnType("nchar(14)");

                entity.Property(e => e.Accidente_centro_CIF_otra).HasColumnType("nchar(14)");

                entity.Property(e => e.Accidente_direccion).HasMaxLength(200);

                entity.Property(e => e.Accidente_empresa_CIF).HasColumnType("nchar(14)");

                entity.Property(e => e.Accidente_empresa_CNAE_codigo).HasColumnType("nchar(10)");

                entity.Property(e => e.Accidente_empresa_CNAE_texto).HasMaxLength(200);

                entity.Property(e => e.Accidente_empresa_codigo_postal).HasColumnType("nchar(5)");

                entity.Property(e => e.Accidente_empresa_domicilio).HasMaxLength(200);

                entity.Property(e => e.Accidente_empresa_municipio).HasColumnType("nchar(5)");

                entity.Property(e => e.Accidente_empresa_provincia).HasColumnType("nchar(2)");

                entity.Property(e => e.Accidente_empresa_razon_social).HasMaxLength(50);

                entity.Property(e => e.Accidente_empresa_telefono).HasColumnType("nchar(14)");

                entity.Property(e => e.Accidente_fecha_accidente).HasColumnType("datetime");

                entity.Property(e => e.Accidente_fecha_baja).HasColumnType("datetime");

                entity.Property(e => e.Accidente_lugar).HasColumnType("nchar(2)");

                entity.Property(e => e.Accidente_municipio).HasColumnType("nchar(5)");

                entity.Property(e => e.Accidente_pais).HasColumnType("nchar(3)");

                entity.Property(e => e.Accidente_provincia).HasColumnType("nchar(2)");

                entity.Property(e => e.Accidente_via_km).HasMaxLength(100);

                entity.Property(e => e.Actores_empresa_cargo).HasMaxLength(50);

                entity.Property(e => e.Actores_empresa_entidad_gestora_codigo).HasColumnType("nchar(4)");

                entity.Property(e => e.Actores_empresa_fecha_presentacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Actores_empresa_nombre_apellidos).HasMaxLength(200);

                entity.Property(e => e.Actores_empresa_provincia).HasMaxLength(50);

                entity.Property(e => e.Apellido1).HasMaxLength(50);

                entity.Property(e => e.Apellido2).HasMaxLength(50);

                entity.Property(e => e.Asistenciales_grado).HasColumnType("nchar(2)");

                entity.Property(e => e.Asistenciales_hospital_nombre).HasMaxLength(100);

                entity.Property(e => e.Asistenciales_lesion).HasColumnType("nchar(3)");

                entity.Property(e => e.Asistenciales_medico_domicilio).HasMaxLength(200);

                entity.Property(e => e.Asistenciales_medico_nombre).HasMaxLength(50);

                entity.Property(e => e.Asistenciales_medico_telefono).HasColumnType("nchar(14)");

                entity.Property(e => e.Asistenciales_parte).HasColumnType("nchar(2)");

                entity.Property(e => e.Asistenciales_tipo_asistencia)
                    .IsRequired()
                    .HasColumnType("nchar(2)");

                entity.Property(e => e.CNO).HasMaxLength(200);

                entity.Property(e => e.CNO_codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codigo_postal).HasColumnType("nchar(10)");

                entity.Property(e => e.Contrato).HasColumnType("nchar(3)");

                entity.Property(e => e.DNI).HasColumnType("nchar(14)");

                entity.Property(e => e.Domicilio).HasMaxLength(200);

                entity.Property(e => e.Economicos_anual_B1).HasColumnType("money");

                entity.Property(e => e.Economicos_anual_B2).HasColumnType("money");

                entity.Property(e => e.Economicos_dias_ejercicio).HasDefaultValueSql("0");

                entity.Property(e => e.Economicos_mensual_dias).HasDefaultValueSql("0");

                entity.Property(e => e.Economicos_mensual_mes_anterior)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Empresa_CNAE_codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Empresa_CNAE_texto).HasMaxLength(200);

                entity.Property(e => e.Empresa_NSS).HasColumnType("nchar(14)");

                entity.Property(e => e.Empresa_codigo_postal).HasColumnType("nchar(10)");

                entity.Property(e => e.Empresa_domicilio).HasMaxLength(200);

                entity.Property(e => e.Empresa_municipio).HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa_nif).HasColumnType("nchar(14)");

                entity.Property(e => e.Empresa_provincia).HasColumnType("nchar(2)");

                entity.Property(e => e.Empresa_razon).HasMaxLength(50);

                entity.Property(e => e.Empresa_telefono).HasMaxLength(50);

                entity.Property(e => e.Fecha_ingreso).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_nacimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Municipio).HasMaxLength(100);

                entity.Property(e => e.NSS).HasColumnType("nchar(12)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Oran_AACC_final).HasColumnType("datetime");

                entity.Property(e => e.Oran_AACC_inicio).HasColumnType("datetime");

                entity.Property(e => e.Oran_AACC_revision).HasColumnType("datetime");

                entity.Property(e => e.Oran_accidente_alta).HasColumnType("datetime");

                entity.Property(e => e.Oran_departamento).HasColumnType("nchar(20)");

                entity.Property(e => e.Oran_empresa).HasColumnType("nchar(2)");

                entity.Property(e => e.Oran_fecha_informe).HasColumnType("smalldatetime");

                entity.Property(e => e.Oran_investigador).HasColumnType("nchar(4)");

                entity.Property(e => e.Oran_lugar).HasColumnType("nchar(30)");

                entity.Property(e => e.Oran_maquina).HasMaxLength(50);

                entity.Property(e => e.Oran_operario).HasColumnType("nchar(4)");

                entity.Property(e => e.Oran_repeticion).HasColumnType("nchar(30)");

                entity.Property(e => e.Oran_responsable).HasMaxLength(50);

                entity.Property(e => e.Oran_revisado).HasColumnType("nchar(4)");

                entity.Property(e => e.Oran_testigo).HasMaxLength(50);

                entity.Property(e => e.Oran_turno).HasColumnType("nchar(20)");

                entity.Property(e => e.Pais).HasMaxLength(35);

                entity.Property(e => e.Provincia).HasMaxLength(35);

                entity.Property(e => e.Referencia).HasColumnType("nchar(12)");

                entity.Property(e => e.Regimen_SS).HasColumnType("nchar(2)");

                entity.Property(e => e.Sexo).HasColumnType("nchar(1)");

                entity.Property(e => e.Situacion).HasColumnType("nchar(2)");

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.Tipo).HasColumnType("nchar(10)");

                entity.Property(e => e.Trabajador_atep).HasColumnType("nchar(3)");

                entity.Property(e => e.Traspasado).HasColumnType("numeric");

                entity.HasOne(d => d.CNO_codigoNavigation)
                    .WithMany(p => p.Personal_accidentes)
                    .HasForeignKey(d => d.CNO_codigo)
                    .HasConstraintName("FK_Personal_accidentes_Personal_accidentes_CNO");

                entity.HasOne(d => d.Empresa_CNAE_codigoNavigation)
                    .WithMany(p => p.Personal_accidentes)
                    .HasForeignKey(d => d.Empresa_CNAE_codigo)
                    .HasConstraintName("FK_Personal_accidentes_Personal_accidentes_CNAE");
            });

            modelBuilder.Entity<Personal_accidentes_CNAE>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Accidentes_CNAE");

                entity.ToTable("Personal_accidentes_CNAE", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Usado).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_accidentes_CNO>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Accidentes_CNO");

                entity.ToTable("Personal_accidentes_CNO", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Usado).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_accidentes_actividad_actual>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Accidentes_Actividad_Fisica");

                entity.ToTable("Personal_accidentes_actividad_actual", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(150);

                entity.Property(e => e.Usado).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_accidentes_cargos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_accidentes_cargos");

                entity.ToTable("Personal_accidentes_cargos", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(40);
            });

            modelBuilder.Entity<Personal_accidentes_causa>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Accidentes_Causa");

                entity.ToTable("Personal_accidentes_causa", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Usado).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_accidentes_descripcion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Accidentes_Maestro");

                entity.ToTable("Personal_accidentes_descripcion", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<Personal_accidentes_grado_lesion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_accidentes_grado_lesion");

                entity.ToTable("Personal_accidentes_grado_lesion", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Personal_accidentes_lesion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_accidentes_lesion");

                entity.ToTable("Personal_accidentes_lesion", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(150);

                entity.Property(e => e.Usado).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_accidentes_localizacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_accidentes_tipo_lugar");

                entity.ToTable("Personal_accidentes_localizacion", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Personal_accidentes_lugar>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Accidentes_Tipos_lugar");

                entity.ToTable("Personal_accidentes_lugar", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Usado).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_accidentes_motivo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Accidentes_Forma_Codigo");

                entity.ToTable("Personal_accidentes_motivo", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(150);

                entity.Property(e => e.Usado).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_accidentes_objetos_implicados>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Accidentes_Agente_Material");

                entity.ToTable("Personal_accidentes_objetos_implicados", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(8)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(150);

                entity.Property(e => e.Usado).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_accidentes_parte>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_accidentes_parte");

                entity.ToTable("Personal_accidentes_parte", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(150);
            });

            modelBuilder.Entity<Personal_accidentes_repeticion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_accidentes_repeticion");

                entity.ToTable("Personal_accidentes_repeticion", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Personal_accidentes_seccion_estadisticas>(entity =>
            {
                entity.HasKey(e => e.Ind)
                    .HasName("PK_Personal_accidentes_seccion_estadisticas");

                entity.ToTable("Personal_accidentes_seccion_estadisticas", "RecursosHumanos");

                entity.Property(e => e.Numero_Accidentes_Baja).HasDefaultValueSql("0");

                entity.Property(e => e.Numero_Accidentes_NoBaja).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_accidentes_secciones>(entity =>
            {
                entity.HasKey(e => e.CodigoSeccion)
                    .HasName("PK_Personal_accidentes_secciones");

                entity.ToTable("Personal_accidentes_secciones", "RecursosHumanos");

                entity.Property(e => e.CodigoSeccion).ValueGeneratedNever();

                entity.Property(e => e.Seccion).HasMaxLength(50);

                entity.Property(e => e.Trabajan).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_accidentes_situacion_profesional>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_accidentes_situacion_profesional");

                entity.ToTable("Personal_accidentes_situacion_profesional", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Personal_accidentes_tipo_asistencia>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_accidentes_tipo_asistencia");

                entity.ToTable("Personal_accidentes_tipo_asistencia", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Personal_accidentes_tipo_trabajo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_accidentes_tipo_trabajo");

                entity.ToTable("Personal_accidentes_tipo_trabajo", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(200);
            });

            modelBuilder.Entity<Personal_almacenes_vestuarios>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Almacenes_Vestuario");

                entity.ToTable("Personal_almacenes_vestuarios", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_calendarios>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_operario_calendario");

                entity.ToTable("Personal_calendarios", "RecursosHumanos");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Centro).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Horario).HasColumnType("nchar(30)");

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.Property(e => e.Tipo_dia).HasColumnType("nchar(2)");

                entity.HasOne(d => d.PersonalNavigation)
                    .WithMany(p => p.Personal_calendarios)
                    .HasForeignKey(d => d.Personal)
                    .HasConstraintName("FK_Personal_calendarios_operario_Personal");

                entity.HasOne(d => d.Tipo_diaNavigation)
                    .WithMany(p => p.Personal_calendarios)
                    .HasForeignKey(d => d.Tipo_dia)
                    .HasConstraintName("FK_Personal_calendarios_operario_Personal_calendarios_tipo_dia");
            });

            modelBuilder.Entity<Personal_calendarios_base>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_calendario_base");

                entity.ToTable("Personal_calendarios_base", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_calendarios_base_detalle>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Calendarios_base_detalle");

                entity.ToTable("Personal_calendarios_base_detalle", "RecursosHumanos");

                entity.Property(e => e.Calendario).HasColumnType("nchar(5)");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Tipo_dia).HasColumnType("nchar(2)");
            });

            modelBuilder.Entity<Personal_calendarios_tipo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_calendarios_tipo_dia");

                entity.ToTable("Personal_calendarios_tipo", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Color).HasColumnType("nchar(20)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_cargos_empresa>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_car");

                entity.ToTable("Personal_cargos_empresa", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(40)");
            });

            modelBuilder.Entity<Personal_categorias>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Categorias");

                entity.ToTable("Personal_categorias", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones).HasMaxLength(1000);
            });

            modelBuilder.Entity<Personal_categorias_historico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_categorias_historico");

                entity.ToTable("Personal_categorias_historico", "RecursosHumanos");

                entity.Property(e => e.Categoria).HasColumnType("nchar(2)");

                entity.Property(e => e.Fecha_categoria)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.HasOne(d => d.CategoriaNavigation)
                    .WithMany(p => p.Personal_categorias_historico)
                    .HasForeignKey(d => d.Categoria)
                    .HasConstraintName("FK_Personal_categorias_historico_Personal_categorias");

                entity.HasOne(d => d.PersonalNavigation)
                    .WithMany(p => p.Personal_categorias_historico)
                    .HasForeignKey(d => d.Personal)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Personal_categorias_historico_Personal");
            });

            modelBuilder.Entity<Personal_contratos_oficiales>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Contratos_Oficiales");

                entity.ToTable("Personal_contratos_oficiales", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion_contrato).HasMaxLength(50);
            });

            modelBuilder.Entity<Personal_contratos_oficiales_bonificaciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_contratos_oficiales_bonificaciones");

                entity.ToTable("Personal_contratos_oficiales_bonificaciones", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_curriculum_vitae>(entity =>
            {
                entity.ToTable("Personal_curriculum_vitae", "RecursosHumanos");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Apellidos_nombre).HasMaxLength(50);

                entity.Property(e => e.Departamento).HasMaxLength(30);

                entity.Property(e => e.Fecha_alta).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_nacimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Idiomas).HasMaxLength(50);

                entity.Property(e => e.Nota).HasColumnType("ntext");

                entity.Property(e => e.Provincia).HasColumnType("nchar(2)");

                entity.Property(e => e.Rama).HasMaxLength(50);

                entity.Property(e => e.Referencia).HasMaxLength(50);

                entity.Property(e => e.Titulacion).HasMaxLength(50);
            });

            modelBuilder.Entity<Personal_departamentos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Departamentos");

                entity.ToTable("Personal_departamentos", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Abreviatura).HasColumnType("nchar(2)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.CPais).HasColumnType("nchar(3)");

                entity.Property(e => e.CPostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Compras).HasDefaultValueSql("0");

                entity.Property(e => e.Comunidad).HasColumnType("nchar(35)");

                entity.Property(e => e.Departamento).HasMaxLength(25);

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Email1).HasMaxLength(50);

                entity.Property(e => e.Email2).HasMaxLength(50);

                entity.Property(e => e.Email3).HasMaxLength(50);

                entity.Property(e => e.Extension).HasColumnType("nchar(5)");

                entity.Property(e => e.Fax1).HasMaxLength(50);

                entity.Property(e => e.Fax2).HasMaxLength(50);

                entity.Property(e => e.Firma).HasColumnType("image");

                entity.Property(e => e.Ftp).HasMaxLength(50);

                entity.Property(e => e.Imagen1).HasColumnType("image");

                entity.Property(e => e.Imagen2).HasColumnType("image");

                entity.Property(e => e.Imagen3).HasColumnType("image");

                entity.Property(e => e.Internet).HasMaxLength(50);

                entity.Property(e => e.Movil1).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Padre).HasColumnType("nchar(3)");

                entity.Property(e => e.Pais).HasColumnType("nchar(35)");

                entity.Property(e => e.Poblacion).HasColumnType("nchar(40)");

                entity.Property(e => e.Provincia).HasColumnType("nchar(35)");

                entity.Property(e => e.Responsable).HasColumnType("nchar(4)");

                entity.Property(e => e.Seccion).HasColumnType("nchar(3)");

                entity.Property(e => e.Telefono).HasMaxLength(50);

                entity.Property(e => e.Telefono1).HasMaxLength(50);

                entity.Property(e => e.Telefono2).HasMaxLength(50);

                entity.Property(e => e.Tipo_tarea).HasColumnType("nchar(20)");

                entity.Property(e => e.Ubicacion).HasMaxLength(50);

                entity.Property(e => e.Ventas).HasDefaultValueSql("0");

                entity.Property(e => e.VoIp1).HasMaxLength(50);

                entity.Property(e => e.VoIp2).HasMaxLength(50);
            });

            modelBuilder.Entity<Personal_empresas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Empresas");

                entity.ToTable("Personal_empresas", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(20);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_empresas_historico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_empresas_historico");

                entity.ToTable("Personal_empresas_historico", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(2)");

                entity.Property(e => e.Fecha_alta).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_baja).HasColumnType("smalldatetime");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Personal).HasColumnType("nchar(4)");
            });

            modelBuilder.Entity<Personal_equipamiento>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Epis");

                entity.ToTable("Personal_equipamiento", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_equipamiento_base>(entity =>
            {
                entity.HasKey(e => new { e.Personal, e.Equipamiento })
                    .HasName("PK_Personal_equipamiento_base_1");

                entity.ToTable("Personal_equipamiento_base", "RecursosHumanos");

                entity.HasIndex(e => new { e.Equipamiento, e.Personal })
                    .HasName("IX_Personal_equipamiento_base")
                    .IsUnique();

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.Property(e => e.Equipamiento).HasColumnType("nchar(3)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Unidades).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_equipamiento_movimientos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Vestuario");

                entity.ToTable("Personal_equipamiento_movimientos", "RecursosHumanos");

                entity.Property(e => e.Epis).HasColumnType("nchar(3)");

                entity.Property(e => e.Fecha_entrega).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_sistema)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Personal)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.Unidades).HasDefaultValueSql("0");

                entity.HasOne(d => d.EpisNavigation)
                    .WithMany(p => p.Personal_equipamiento_movimientos)
                    .HasForeignKey(d => d.Epis)
                    .HasConstraintName("FK_Personal_equipamiento_movimientos_Personal_equipamiento");

                entity.HasOne(d => d.PersonalNavigation)
                    .WithMany(p => p.Personal_equipamiento_movimientos)
                    .HasForeignKey(d => d.Personal)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Personal_equipamiento_movimientos_Personal");
            });

            modelBuilder.Entity<Personal_ere>(entity =>
            {
                entity.HasKey(e => new { e.Empleado, e.Fecha })
                    .HasName("PK_Personal_ere");

                entity.ToTable("Personal_ere", "RecursosHumanos");

                entity.Property(e => e.Empleado).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Personal_especialidades>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Especialidades");

                entity.ToTable("Personal_especialidades", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(20);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_estados>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_estados");

                entity.ToTable("Personal_estados", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_evaluacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Evaluacion");

                entity.ToTable("Personal_evaluacion", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(4)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_evaluacion_anual>(entity =>
            {
                entity.HasKey(e => e.Codaux)
                    .HasName("PK_Evaluacion_Anual");

                entity.ToTable("Personal_evaluacion_anual", "RecursosHumanos");

                entity.HasIndex(e => new { e.Codigo, e.Ejercicio })
                    .HasName("IX_Evaluacion_Anual");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Indicador).HasColumnType("nchar(1)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_evaluacion_equipo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Evaluacion_Equipo");

                entity.ToTable("Personal_evaluacion_equipo", "RecursosHumanos");

                entity.HasIndex(e => new { e.Responsable, e.Operario })
                    .HasName("IX_Personal_evaluacion_equipo")
                    .IsUnique();

                entity.Property(e => e.Operario)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Responsable)
                    .IsRequired()
                    .HasColumnType("nchar(4)");
            });

            modelBuilder.Entity<Personal_formacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_formacion");

                entity.ToTable("Personal_formacion", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.Property(e => e.Titulacion).HasColumnType("nchar(3)");

                entity.HasOne(d => d.PersonalNavigation)
                    .WithMany(p => p.Personal_formacion)
                    .HasForeignKey(d => d.Personal)
                    .HasConstraintName("FK_Personal_formacion_Personal");

                entity.HasOne(d => d.TitulacionNavigation)
                    .WithMany(p => p.Personal_formacion)
                    .HasForeignKey(d => d.Titulacion)
                    .HasConstraintName("FK_Personal_formacion_Personal_titulaciones");
            });

            modelBuilder.Entity<Personal_formacion_centros>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_formacion_centros");

                entity.ToTable("Personal_formacion_centros", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Personal_formacion_idiomas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_idiomas_formacion");

                entity.ToTable("Personal_formacion_idiomas", "RecursosHumanos");

                entity.HasIndex(e => new { e.Idioma, e.Personal })
                    .HasName("IX_Personal_idiomas_formacion");

                entity.Property(e => e.Idioma).HasColumnType("nchar(2)");

                entity.Property(e => e.Nivel_escrito).HasDefaultValueSql("0");

                entity.Property(e => e.Nivel_hablado).HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.HasOne(d => d.IdiomaNavigation)
                    .WithMany(p => p.Personal_formacion_idiomas)
                    .HasForeignKey(d => d.Idioma)
                    .HasConstraintName("FK_Personal_idiomas_formacion_Personal_Idiomas");

                entity.HasOne(d => d.PersonalNavigation)
                    .WithMany(p => p.Personal_formacion_idiomas)
                    .HasForeignKey(d => d.Personal)
                    .HasConstraintName("FK_Personal_idiomas_formacion_Personal");
            });

            modelBuilder.Entity<Personal_formacion_tipo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_formacion_tipo");

                entity.ToTable("Personal_formacion_tipo", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasColumnType("nchar(50)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_formacion_titulaciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_titulaciones");

                entity.ToTable("Personal_formacion_titulaciones", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(150);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Oficial).HasDefaultValueSql("0");

                entity.Property(e => e.Rama).HasColumnType("nchar(3)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(2)");

                entity.HasOne(d => d.RamaNavigation)
                    .WithMany(p => p.Personal_formacion_titulaciones)
                    .HasForeignKey(d => d.Rama)
                    .HasConstraintName("FK_Personal_titulaciones_Personal_ramas");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Personal_formacion_titulaciones)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Personal_formacion_titulaciones_Personal_formacion_tipo");
            });

            modelBuilder.Entity<Personal_grupos_trabajo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_grupo_trabajo");

                entity.ToTable("Personal_grupos_trabajo", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Descripcion_tareas).HasColumnType("ntext");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Responsable).HasColumnType("nchar(5)");

                entity.Property(e => e.Seccion).HasColumnType("nchar(3)");
            });

            modelBuilder.Entity<Personal_grupos_trabajo_relacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_grupos_trabajo_relacion");

                entity.ToTable("Personal_grupos_trabajo_relacion", "RecursosHumanos");

                entity.Property(e => e.Grupo_trabajo).HasColumnType("nchar(5)");

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.HasOne(d => d.Grupo_trabajoNavigation)
                    .WithMany(p => p.Personal_grupos_trabajo_relacion)
                    .HasForeignKey(d => d.Grupo_trabajo)
                    .HasConstraintName("FK_Personal_grupos_trabajo_operario_Personal_grupo_trabajo");

                entity.HasOne(d => d.PersonalNavigation)
                    .WithMany(p => p.Personal_grupos_trabajo_relacion)
                    .HasForeignKey(d => d.Personal)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Personal_grupos_trabajo_operario_Personal");
            });

            modelBuilder.Entity<Personal_horarios>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_horarios");

                entity.ToTable("Personal_horarios", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(30);

                entity.Property(e => e.Hora_desde).HasColumnType("smalldatetime");

                entity.Property(e => e.Hora_hasta).HasColumnType("smalldatetime");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_idiomas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_Idiomas");

                entity.ToTable("Personal_idiomas", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_incidencias>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_MIncidencias");

                entity.ToTable("Personal_incidencias", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_perfil>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_perfil");

                entity.ToTable("Personal_perfil", "RecursosHumanos");

                entity.Property(e => e.Departamento).HasMaxLength(30);

                entity.Property(e => e.Fecha_edicion).HasColumnType("smalldatetime");

                entity.Property(e => e.Perfil).HasMaxLength(150);

                entity.Property(e => e.Puesto).HasMaxLength(30);
            });

            modelBuilder.Entity<Personal_perfil_tareas>(entity =>
            {
                entity.HasKey(e => e.PerfilTareaId)
                    .HasName("PK_Personal_perfil_tareas");

                entity.ToTable("Personal_perfil_tareas", "RecursosHumanos");

                entity.Property(e => e.Departamento).HasMaxLength(30);

                entity.Property(e => e.Fecha_Edicion).HasColumnType("smalldatetime");

                entity.Property(e => e.Puesto).HasMaxLength(30);

                entity.Property(e => e.Tareas).HasMaxLength(150);
            });

            modelBuilder.Entity<Personal_presencia>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_presencia");

                entity.ToTable("Personal_presencia", "RecursosHumanos");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(3)");

                entity.HasOne(d => d.PersonalNavigation)
                    .WithMany(p => p.Personal_presencia)
                    .HasForeignKey(d => d.Personal)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Personal_presencia_Personal");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Personal_presencia)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Personal_presencia_Personal_presencia_tipos");
            });

            modelBuilder.Entity<Personal_presencia_fotos>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Personal_presencia_fotos");

                entity.ToTable("Personal_presencia_fotos", "RecursosHumanos");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Personal_presencia_fotos)
                    .HasForeignKey(d => d.Codigo)
                    .HasConstraintName("FK_Personal_presencia_fotos_Personal_presencia");
            });

            modelBuilder.Entity<Personal_presencia_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_presencia_tipos");

                entity.ToTable("Personal_presencia_tipos", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<Personal_prima_asistencia_puntualidad>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Prima_Asistencia_Puntualidad");

                entity.ToTable("Personal_prima_asistencia_puntualidad", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Valor).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_prima_produccion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Prima_Produccion");

                entity.ToTable("Personal_prima_produccion", "RecursosHumanos");

                entity.HasIndex(e => e.Abreviatura)
                    .HasName("IX_Prima_Produccion")
                    .IsUnique();

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Abreviatura)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Valor)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Personal_puestos_trabajo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_puestos_trabajo");

                entity.ToTable("Personal_puestos_trabajo", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Departamento).HasMaxLength(30);

                entity.Property(e => e.Puesto).HasMaxLength(30);
            });

            modelBuilder.Entity<Personal_ramas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_ramas");

                entity.ToTable("Personal_ramas", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Personal_regimen_trabajo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_regimen_trabajo");

                entity.ToTable("Personal_regimen_trabajo", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(150);
            });

            modelBuilder.Entity<Personal_secciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Secciones");

                entity.ToTable("Personal_secciones", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_seguridad_social_epigrafes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Epigrafe_SS");

                entity.ToTable("Personal_seguridad_social_epigrafes", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_seguridad_social_grupo_cotizacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Grupo_Cotizacion");

                entity.ToTable("Personal_seguridad_social_grupo_cotizacion", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(60);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Personal_tipo_contrato>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_tipo_contrato");

                entity.ToTable("Personal_tipo_contrato", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Tipo_contrato).HasMaxLength(150);
            });

            modelBuilder.Entity<Personal_turnos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Personal_turnos");

                entity.ToTable("Personal_turnos", "RecursosHumanos");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Abreviatura).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Piezas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Troqueles_piezas");

                entity.ToTable("Piezas", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Planificacion_cataforesis>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Planificacion_cataforesis");

                entity.ToTable("Planificacion_cataforesis", "Picking");

                entity.HasIndex(e => e.Fecha_final)
                    .HasName("Idx_FechaFinal");

                entity.HasIndex(e => e.Fecha_inicial)
                    .HasName("Idx_FechaInicial");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicial)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lote_entrega).HasDefaultValueSql("0");

                entity.Property(e => e.Orden).HasDefaultValueSql("0");

                entity.Property(e => e.Pedidas).HasDefaultValueSql("0");

                entity.Property(e => e.Pedido_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Pedido_modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Pendientes).HasDefaultValueSql("0");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Servidas).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_jaula).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Planificador_informe>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Planificador_informe");

                entity.ToTable("Planificador_informe", "Produccion");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Articulo_descripcion).HasMaxLength(200);

                entity.Property(e => e.Cantidad_fabricada)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_fabricar)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro_destino).HasColumnType("nchar(6)");

                entity.Property(e => e.Centro_grupo).HasColumnType("nchar(6)");

                entity.Property(e => e.Centro_tipo).HasColumnType("nchar(20)");

                entity.Property(e => e.Centro_trabajo).HasColumnType("nchar(6)");

                entity.Property(e => e.Dia1).HasDefaultValueSql("0");

                entity.Property(e => e.Dia2).HasDefaultValueSql("0");

                entity.Property(e => e.Dia3).HasDefaultValueSql("0");

                entity.Property(e => e.Dia4).HasDefaultValueSql("0");

                entity.Property(e => e.Dia5).HasDefaultValueSql("0");

                entity.Property(e => e.Dia6).HasDefaultValueSql("0");

                entity.Property(e => e.Dia7).HasDefaultValueSql("0");

                entity.Property(e => e.Estado).HasDefaultValueSql("0");

                entity.Property(e => e.Existencias).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_alta)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_requerida).HasColumnType("smalldatetime");

                entity.Property(e => e.Lote_entrega).HasDefaultValueSql("0");

                entity.Property(e => e.Operarios).HasDefaultValueSql("0");

                entity.Property(e => e.Orden).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo_descripcion).HasMaxLength(200);

                entity.Property(e => e.PEntrar).HasDefaultValueSql("0");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("3");

                entity.Property(e => e.Punto_pedido).HasDefaultValueSql("0");

                entity.Property(e => e.Semana1).HasDefaultValueSql("0");

                entity.Property(e => e.Semana2).HasDefaultValueSql("0");

                entity.Property(e => e.Semana3).HasDefaultValueSql("0");

                entity.Property(e => e.Semana4).HasDefaultValueSql("0");

                entity.Property(e => e.Tiempo_estimado).HasDefaultValueSql("0");

                entity.Property(e => e.Tiempo_preparacion).HasDefaultValueSql("0");

                entity.Property(e => e.Tiempo_total).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Traspasado).HasDefaultValueSql("0");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Posiciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Troqueles_posicion");

                entity.ToTable("Posiciones", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(1)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Precios_copias>(entity =>
            {
                entity.HasKey(e => e.Operacion)
                    .HasName("PK_Precios_copias");

                entity.ToTable("Precios_copias", "Precios");

                entity.Property(e => e.Copia_grupos_precios).HasDefaultValueSql("1");

                entity.Property(e => e.Copia_precios_especiales).HasDefaultValueSql("1");

                entity.Property(e => e.Copia_precios_especiales_cantidad).HasDefaultValueSql("1");

                entity.Property(e => e.Copia_precios_tarifa).HasDefaultValueSql("1");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Registros_grupos_tarifas).HasDefaultValueSql("0");

                entity.Property(e => e.Registros_precios_especiales).HasDefaultValueSql("0");

                entity.Property(e => e.Registros_precios_especiales_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Registros_precios_tarifa).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Preparacion_previa_material_unidades>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Previa_material_unidades");

                entity.ToTable("Preparacion_previa_material_unidades", "Picking");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad_planificada).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_preparada).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Cliente_empresa).HasMaxLength(100);

                entity.Property(e => e.Fecha_entrega).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_pedido).HasColumnType("smalldatetime");

                entity.Property(e => e.Jaula).HasColumnType("nchar(10)");

                entity.Property(e => e.Pedido_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Pedido_modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Planificacion_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Procesada).HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Preparacion_previa_material_unidades)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Preparacion_previa_material_unidades_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Preparacion_previa_material_unidades)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Preparacion_previa_material_unidades_clientes");

                entity.HasOne(d => d.PedidoNavigation)
                    .WithMany(p => p.Preparacion_previa_material_unidades)
                    .HasForeignKey(d => d.Pedido)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Preparacion_previa_material_unidades_ventas_pedidos_cabecera");

                entity.HasOne(d => d.Pedido_numero_lineaNavigation)
                    .WithMany(p => p.Preparacion_previa_material_unidades)
                    .HasForeignKey(d => d.Pedido_numero_linea)
                    .HasConstraintName("FK_Preparacion_previa_material_unidades_ventas_pedidos_detalle");
            });

            modelBuilder.Entity<Preparacion_previa_material_volumen>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_albaranes_carga_material_preparado");

                entity.ToTable("Preparacion_previa_material_volumen", "Picking");

                entity.HasIndex(e => e.Planificacion_fecha)
                    .HasName("Idx_PlanificacionFecha");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad_planificada).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad_preparada).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Cliente_empresa).HasMaxLength(100);

                entity.Property(e => e.Fecha_entrega).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_pedido).HasColumnType("smalldatetime");

                entity.Property(e => e.Jaula).HasColumnType("nchar(10)");

                entity.Property(e => e.Pedido_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Pedido_modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Planificacion_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Procesada).HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Preparacion_previa_material_volumen)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Preparacion_previa_material_Articulos");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Preparacion_previa_material_volumen)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Preparacion_previa_material_Clientes");

                entity.HasOne(d => d.PedidoNavigation)
                    .WithMany(p => p.Preparacion_previa_material_volumen)
                    .HasForeignKey(d => d.Pedido)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Preparacion_previa_material_Ventas_pedidos_cabecera");

                entity.HasOne(d => d.Pedido_numero_lineaNavigation)
                    .WithMany(p => p.Preparacion_previa_material_volumen)
                    .HasForeignKey(d => d.Pedido_numero_linea)
                    .HasConstraintName("FK_Preparacion_previa_material_Ventas_pedidos_detalle");
            });

            modelBuilder.Entity<Prioridades>(entity =>
            {
                entity.HasKey(e => e.Prioridad)
                    .HasName("PK_Ordenes_trabajo_prioridad");

                entity.ToTable("Prioridades", "General");

                entity.Property(e => e.Color).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Procesos_externos>(entity =>
            {
                entity.HasKey(e => e.ProcesoId)
                    .HasName("PK_Procesos_externos");

                entity.ToTable("Procesos_externos", "General");

                entity.HasIndex(e => e.Procesado)
                    .HasName("Idx_procesado");

                entity.Property(e => e.ComputerName).HasMaxLength(100);

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Procesado).HasDefaultValueSql("0");

                entity.Property(e => e.Proceso).HasColumnType("varchar(1000)");
            });

            modelBuilder.Entity<Procesos_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Procesos_tipos");

                entity.ToTable("Procesos_tipos", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Activo).HasDefaultValueSql("0");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores");

                entity.ToTable("Proveedores", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Accion_ruptura_riesgo).HasDefaultValueSql("0");

                entity.Property(e => e.Agencia1).HasColumnType("nchar(6)");

                entity.Property(e => e.Agencia2).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente_aduanas_1).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente_aduanas_2).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Ajuste_vencimientos).HasDefaultValueSql("0");

                entity.Property(e => e.Autofacturacion).HasDefaultValueSql("1");

                entity.Property(e => e.AutofacturacionConfiguracion).HasDefaultValueSql("1");

                entity.Property(e => e.Bloqueo_informacion).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_operaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Carencia).HasDefaultValueSql("0");

                entity.Property(e => e.Clave1).HasMaxLength(20);

                entity.Property(e => e.Clave2).HasMaxLength(20);

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Confirming_pronto_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Confirming_tipo).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Decimales_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_precios).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_totales).HasDefaultValueSql("2");

                entity.Property(e => e.Departamento).HasColumnType("nchar(3)");

                entity.Property(e => e.Descuento_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_linea_detalle)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_pronto_pago)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_volumen)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Dia_1_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_2_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_3_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Divisa)
                    .HasColumnType("nchar(3)")
                    .HasDefaultValueSql("'EUR'");

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Factor)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Fecha_alta)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Ftp).HasMaxLength(100);

                entity.Property(e => e.Grafico).HasMaxLength(200);

                entity.Property(e => e.Grupo_sinonimos).HasColumnType("nchar(6)");

                entity.Property(e => e.Horario_descarga1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_descarga2).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina2).HasColumnType("nchar(5)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Incoterm1).HasColumnType("nchar(5)");

                entity.Property(e => e.Incoterm2).HasColumnType("nchar(5)");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Internet_acceso).HasDefaultValueSql("0");

                entity.Property(e => e.Internet_grupo).HasColumnType("nchar(5)");

                entity.Property(e => e.Intrastat).HasDefaultValueSql("0");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Lead_time).HasDefaultValueSql("0");

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Numero).HasDefaultValueSql("0");

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Plazo_entrega).HasDefaultValueSql("0");

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Portes_descuento_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Recargo_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_financiero)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Restos).HasDefaultValueSql("0");

                entity.Property(e => e.Retencion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Riesgo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Riesgo_actual)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Telefono3).HasMaxLength(30);

                entity.Property(e => e.Tipo_recibo).HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Vacaciones_final).HasColumnType("nchar(5)");

                entity.Property(e => e.Vacaciones_inicio).HasColumnType("nchar(5)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);

                entity.Property(e => e.Zona).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Proveedores_articulos_bloqueados>(entity =>
            {
                entity.HasKey(e => new { e.Proveedor, e.Articulo })
                    .HasName("PK_Proveedores_articulos_bloqueados");

                entity.ToTable("Proveedores_articulos_bloqueados", "Gestion");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Proveedores_articulos_bloqueados)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Proveedores_articulos_bloqueados_Articulos");
            });

            modelBuilder.Entity<Proveedores_bancos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores_bancos");

                entity.ToTable("Proveedores_bancos", "Gestion");

                entity.Property(e => e.Agencia).HasColumnType("nchar(4)");

                entity.Property(e => e.Cuenta).HasMaxLength(10);

                entity.Property(e => e.Dc).HasColumnType("nchar(2)");

                entity.Property(e => e.Entidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Iban).HasColumnType("nchar(34)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Sufijo).HasColumnType("nchar(10)");

                entity.Property(e => e.Swift).HasColumnType("nchar(11)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(2)");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Proveedores_bancos)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proveedores_bancos_Proveedores");
            });

            modelBuilder.Entity<Proveedores_certificaciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_certificaciones");

                entity.ToTable("Proveedores_certificaciones", "Gestion");

                entity.Property(e => e.Documento).HasMaxLength(1000);

                entity.Property(e => e.Fecha_caducidad)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Organismo_certificador).HasColumnType("nchar(6)");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo_certificacion).HasColumnType("nchar(2)");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Proveedores_certificaciones)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proveedores_certificaciones_Proveedores");

                entity.HasOne(d => d.Tipo_certificacionNavigation)
                    .WithMany(p => p.Proveedores_certificaciones)
                    .HasForeignKey(d => d.Tipo_certificacion)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Interlocutores_certificaciones_Interlocutores_tipos_certificacion1");
            });

            modelBuilder.Entity<Proveedores_compras_areas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_compras_areas");

                entity.ToTable("Proveedores_compras_areas", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Proveedores_compras_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_compras_tipos");

                entity.ToTable("Proveedores_compras_tipos", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasColumnType("ntext");
            });

            modelBuilder.Entity<Proveedores_confirming_tipos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores_confirming_tipos");

                entity.ToTable("Proveedores_confirming_tipos", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Proveedores_cuentas_contables>(entity =>
            {
                entity.HasKey(e => new { e.Proveedor, e.Tipo })
                    .HasName("PK_Proveedores_cuentas_contables");

                entity.ToTable("Proveedores_cuentas_contables", "Gestion");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo).HasColumnType("nchar(2)");

                entity.Property(e => e.Cuenta).HasColumnType("nchar(20)");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Proveedores_cuentas_contables)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Proveedores_cuentas_contables_Cuentas_contables_tipos");
            });

            modelBuilder.Entity<Proveedores_departamentos>(entity =>
            {
                entity.HasKey(e => new { e.Proveedor, e.Tipo_departamento })
                    .HasName("PK_Proveedores_departamentos");

                entity.ToTable("Proveedores_departamentos", "Gestion");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo_departamento).HasColumnType("nchar(2)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Persona_contacto).HasMaxLength(50);

                entity.HasOne(d => d.Tipo_departamentoNavigation)
                    .WithMany(p => p.Proveedores_departamentos)
                    .HasForeignKey(d => d.Tipo_departamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Proveedores_departamentos_Departamentos_tipos");
            });

            modelBuilder.Entity<Proveedores_direcciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores_direcciones");

                entity.ToTable("Proveedores_direcciones", "Gestion");

                entity.Property(e => e.Acceso_global).HasDefaultValueSql("0");

                entity.Property(e => e.Clave1).HasMaxLength(50);

                entity.Property(e => e.Clave2).HasMaxLength(50);

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Email3).HasMaxLength(100);

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Ruta).HasColumnType("nchar(5)");

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Tipo)
                    .HasColumnType("nchar(2)")
                    .HasDefaultValueSql("'08'");

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Proveedores_direcciones)
                    .HasForeignKey(d => d.Tipo)
                    .HasConstraintName("FK_Proveedores_direcciones_Direcciones_tipos");
            });

            modelBuilder.Entity<Proveedores_graficos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores_graficos");

                entity.ToTable("Proveedores_graficos", "Gestion");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Proveedores_graficos)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proveedores_graficos_Proveedores");
            });

            modelBuilder.Entity<Proveedores_precios_compra>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_precios_compra");

                entity.ToTable("Proveedores_precios_compra", "Precios");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad_final).HasDefaultValueSql("1");

                entity.Property(e => e.Cantidad_inicial).HasDefaultValueSql("1");

                entity.Property(e => e.Clasificacion).HasDefaultValueSql("0");

                entity.Property(e => e.Coste_adicional)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Factor)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Lote).HasColumnType("nchar(10)");

                entity.Property(e => e.Plazo_entrega).HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Recargo)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Proveedores_precios_compra)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proveedores_precios_compra_Articulos");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Proveedores_precios_compra)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proveedores_precios_compra_Proveedores");
            });

            modelBuilder.Entity<Proveedores_presupuestos_prevision>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores_presupuestos_prevision_1");

                entity.ToTable("Proveedores_presupuestos_prevision", "Financiera");

                entity.Property(e => e.Banco_pago_subcuenta).HasColumnType("nchar(9)");

                entity.Property(e => e.Cuenta).HasColumnType("nchar(9)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Estado).HasColumnType("nchar(10)");

                entity.Property(e => e.Fecha_prevista).HasColumnType("smalldatetime");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo).HasDefaultValueSql("0");

                entity.HasOne(d => d.ProveedorNavigation)
                    .WithMany(p => p.Proveedores_presupuestos_prevision)
                    .HasForeignKey(d => d.Proveedor)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proveedores_presupuestos_prevision_Proveedores");
            });

            modelBuilder.Entity<Proveedores_procesos>(entity =>
            {
                entity.HasKey(e => new { e.Proveedor, e.Proceso })
                    .HasName("PK_Proveedores_procesos");

                entity.ToTable("Proveedores_procesos", "Gestion");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Proceso).HasColumnType("nchar(6)");

                entity.Property(e => e.Activo).HasDefaultValueSql("0");

                entity.HasOne(d => d.ProcesoNavigation)
                    .WithMany(p => p.Proveedores_procesos)
                    .HasForeignKey(d => d.Proceso)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Proveedores_procesos_Procesos_tipos");
            });

            modelBuilder.Entity<Proveedores_sinonimos>(entity =>
            {
                entity.HasKey(e => new { e.Proveedor, e.Articulo })
                    .HasName("PK_Proveedores_sinonimos");

                entity.ToTable("Proveedores_sinonimos", "Gestion");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Proveedores_sinonimos)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Proveedores_sinonimos_Articulos");
            });

            modelBuilder.Entity<Proveedores_transporte_expediciones>(entity =>
            {
                entity.HasKey(e => new { e.Agencia, e.Proveedor })
                    .HasName("PK_Proveedores_transporte_expediciones");

                entity.ToTable("Proveedores_transporte_expediciones", "Gestion");

                entity.Property(e => e.Agencia).HasColumnType("nchar(6)");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Reexpedicion).HasDefaultValueSql("0");

                entity.HasOne(d => d.AgenciaNavigation)
                    .WithMany(p => p.Proveedores_transporte_expediciones)
                    .HasForeignKey(d => d.Agencia)
                    .HasConstraintName("FK_Proveedores_transporte_expediciones_Agencias_transporte");
            });

            modelBuilder.Entity<Proveedores_visitas>(entity =>
            {
                entity.HasKey(e => new { e.Proveedor, e.Visita })
                    .HasName("PK_Proveedores_visitas");

                entity.ToTable("Proveedores_visitas", "Gestion");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Visita)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Proyectos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proyectos");

                entity.ToTable("Proyectos", "Produccion");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Coste)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Fecha_final).HasColumnType("datetime");

                entity.Property(e => e.Fecha_final_prevista).HasColumnType("datetime");

                entity.Property(e => e.Fecha_inicio).HasColumnType("datetime");

                entity.Property(e => e.Presupuesto)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proyecto).HasColumnType("nchar(8)");

                entity.Property(e => e.Valoracion_inicial)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Puertos_embarque>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Puertos_embarque");

                entity.ToTable("Puertos_embarque", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Remesas_compras>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Remesas_compras");

                entity.ToTable("Remesas_compras", "Financiera");

                entity.Property(e => e.Remesa_bancaria).HasMaxLength(72);

                entity.HasOne(d => d.RemesaNavigation)
                    .WithMany(p => p.Remesas_compras)
                    .HasForeignKey(d => d.Remesa)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Remesas_compras_Remesas_compras_cabecera");
            });

            modelBuilder.Entity<Remesas_compras_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores_remesas_cabecera");

                entity.ToTable("Remesas_compras_cabecera", "Financiera");

                entity.Property(e => e.Aprobada).HasDefaultValueSql("0");

                entity.Property(e => e.Banco_agencia).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_cuenta).HasColumnType("nchar(10)");

                entity.Property(e => e.Banco_dc).HasColumnType("nchar(10)");

                entity.Property(e => e.Banco_entidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_nombre).HasMaxLength(50);

                entity.Property(e => e.Banco_subcuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Banco_sufijo).HasColumnType("nchar(3)");

                entity.Property(e => e.Confirming_pronto_pago).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Enviada).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_envio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_remesa)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Remesa)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Serie)
                    .HasColumnType("nchar(1)")
                    .HasDefaultValueSql("N'A'");

                entity.Property(e => e.Total_remesa)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Remesas_compras_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Remesas_compras_detalle");

                entity.ToTable("Remesas_compras_detalle", "Financiera");

                entity.HasIndex(e => new { e.Proveedor, e.Factura_codigo, e.Factura_ejercicio, e.Factura_modo, e.Recibo, e.Repeticiones })
                    .HasName("Idx_RemesaProveedorFactura")
                    .IsUnique();

                entity.HasIndex(e => new { e.Proveedor, e.Factura_ejercicio, e.Factura_modo, e.Referencia, e.Recibo, e.Repeticiones })
                    .HasName("NonClusteredIndex-20150206-123724")
                    .IsUnique();

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Factura_codigo)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Factura_ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Factura_modo)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Fecha_factura).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_vencimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Linea).HasDefaultValueSql("0");

                entity.Property(e => e.Notificacion).HasDefaultValueSql("0");

                entity.Property(e => e.Proveedor)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Recibo).IsRequired();

                entity.Property(e => e.Referencia)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Repeticiones).HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Remesas_compras_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Remesas_compras_detalle_Remesas_compras_cabecera");

                entity.HasOne(d => d.FacturaNavigation)
                    .WithMany(p => p.Remesas_compras_detalle)
                    .HasForeignKey(d => d.Factura)
                    .HasConstraintName("FK_Remesas_compras_detalle_Facturas_cabecera");
            });

            modelBuilder.Entity<Remesas_ventas>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Remesas_ventas");

                entity.ToTable("Remesas_ventas", "Financiera");

                entity.Property(e => e.Remesa_bancaria).HasMaxLength(162);

                entity.HasOne(d => d.RemesaNavigation)
                    .WithMany(p => p.Remesas_ventas)
                    .HasForeignKey(d => d.Remesa)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Remesas_ventas_Remesas_ventas_cabecera");
            });

            modelBuilder.Entity<Remesas_ventas_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_remesas_cabecera");

                entity.ToTable("Remesas_ventas_cabecera", "Financiera");

                entity.Property(e => e.Aprobada).HasDefaultValueSql("0");

                entity.Property(e => e.Banco_agencia).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_cuenta).HasColumnType("nchar(10)");

                entity.Property(e => e.Banco_dc).HasColumnType("nchar(2)");

                entity.Property(e => e.Banco_entidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_nombre).HasMaxLength(50);

                entity.Property(e => e.Banco_subcuenta).HasColumnType("nchar(15)");

                entity.Property(e => e.Banco_sufijo).HasColumnType("nchar(3)");

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Enviada).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_envio).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_remesa)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Remesa)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Serie)
                    .HasColumnType("nchar(1)")
                    .HasDefaultValueSql("N'A'");

                entity.Property(e => e.Total_remesa)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Remesas_ventas_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Remesas_ventas_detalle");

                entity.ToTable("Remesas_ventas_detalle", "Financiera");

                entity.HasIndex(e => new { e.Cliente, e.Factura_codigo, e.Factura_modo, e.Factura_ejercicio, e.Recibo, e.Repeticiones })
                    .HasName("NonClusteredIndex-20150205-155314")
                    .IsUnique();

                entity.Property(e => e.Banco_agencia).HasColumnType("nchar(4)");

                entity.Property(e => e.Banco_cuenta).HasColumnType("nchar(10)");

                entity.Property(e => e.Banco_dc).HasColumnType("nchar(2)");

                entity.Property(e => e.Banco_entidad).HasColumnType("nchar(4)");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Concepto).HasMaxLength(100);

                entity.Property(e => e.Factura_codigo)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Factura_ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Factura_modo)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Fecha_factura).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_vencimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Notificacion).HasDefaultValueSql("0");

                entity.Property(e => e.Recibo).IsRequired();

                entity.Property(e => e.Repeticiones).HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Cartera_reciboNavigation)
                    .WithMany(p => p.Remesas_ventas_detalle)
                    .HasForeignKey(d => d.Cartera_recibo)
                    .HasConstraintName("FK_Remesas_ventas_detalle_Cartera_ventas");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Remesas_ventas_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Remesas_ventas_detalle_Remesas_ventas_cabecera");
            });

            modelBuilder.Entity<Remesas_ventas_sepa>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Remesas_ventas_sepa");

                entity.ToTable("Remesas_ventas_sepa", "Financiera");

                entity.Property(e => e.Remesa_bancaria).HasMaxLength(600);

                entity.HasOne(d => d.RemesaNavigation)
                    .WithMany(p => p.Remesas_ventas_sepa)
                    .HasForeignKey(d => d.Remesa)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Remesas_ventas_sepa_Remesas_ventas_cabecera");
            });

            modelBuilder.Entity<Reparto_costes>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores_facturas_cabecera_reparto_costes");

                entity.ToTable("Reparto_costes", "Analitica");

                entity.Property(e => e.Area).HasColumnType("nchar(2)");

                entity.Property(e => e.Asignacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(2)");

                entity.Property(e => e.Cuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Documento).HasColumnType("nchar(20)");

                entity.Property(e => e.Factura_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Factura_ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Factura_modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Ot).HasColumnType("nchar(20)");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Seccion).HasColumnType("nchar(3)");
            });

            modelBuilder.Entity<Rutas_planificadas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_rutas");

                entity.ToTable("Rutas_planificadas", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Dia).HasDefaultValueSql("0");

                entity.Property(e => e.Dia_ciclo_meses).HasDefaultValueSql("0");

                entity.Property(e => e.Domingo).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_limite).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_mensaje).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_mercancia).HasColumnType("smalldatetime");

                entity.Property(e => e.Frecuencia).HasDefaultValueSql("0");

                entity.Property(e => e.Jueves).HasDefaultValueSql("0");

                entity.Property(e => e.Lunes).HasDefaultValueSql("0");

                entity.Property(e => e.Martes).HasDefaultValueSql("0");

                entity.Property(e => e.Miercoles).HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Periodo_ciclo_dias).HasDefaultValueSql("0");

                entity.Property(e => e.Periodo_ciclo_semanas).HasDefaultValueSql("0");

                entity.Property(e => e.Primer_dia_semana).HasDefaultValueSql("0");

                entity.Property(e => e.Primera_semana_meses).HasDefaultValueSql("0");

                entity.Property(e => e.Primero).HasDefaultValueSql("0");

                entity.Property(e => e.Sabado).HasDefaultValueSql("0");

                entity.Property(e => e.Viernes).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Scheduler_configuracion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Sheduling");

                entity.ToTable("Scheduler_configuracion", "General");

                entity.Property(e => e.Activo).HasDefaultValueSql("0");

                entity.Property(e => e.Cuerpo).HasMaxLength(2000);

                entity.Property(e => e.Duracion_fecha_final).HasColumnType("date");

                entity.Property(e => e.Duracion_fecha_inicial)
                    .HasColumnType("date")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Exportar_csv).HasDefaultValueSql("0");

                entity.Property(e => e.Exportar_excel).HasDefaultValueSql("0");

                entity.Property(e => e.Exportar_html).HasDefaultValueSql("0");

                entity.Property(e => e.Exportar_mht).HasDefaultValueSql("0");

                entity.Property(e => e.Exportar_pdf).HasDefaultValueSql("0");

                entity.Property(e => e.Exportar_txt).HasDefaultValueSql("0");

                entity.Property(e => e.Exportar_word).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_creacion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_proxima_ejecucion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_ultima_ejecucion).HasColumnType("smalldatetime");

                entity.Property(e => e.Frecuencia_descripcion).HasMaxLength(200);

                entity.Property(e => e.Frecuencia_diaria_dias).HasDefaultValueSql("1");

                entity.Property(e => e.Frecuencia_ejecucion).HasDefaultValueSql("0");

                entity.Property(e => e.Frecuencia_finalizacion).HasDefaultValueSql("0");

                entity.Property(e => e.Frecuencia_hora_ejecucion).HasColumnType("smalldatetime");

                entity.Property(e => e.Frecuencia_hora_final).HasColumnType("datetime");

                entity.Property(e => e.Frecuencia_hora_inicio)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Frecuencia_mensual_diaria_dia).HasDefaultValueSql("1");

                entity.Property(e => e.Frecuencia_mensual_diaria_mes).HasDefaultValueSql("1");

                entity.Property(e => e.Frecuencia_mensual_periodo_ambito).HasDefaultValueSql("1");

                entity.Property(e => e.Frecuencia_mensual_periodo_dias).HasDefaultValueSql("1");

                entity.Property(e => e.Frecuencia_mensual_periodo_mes).HasDefaultValueSql("1");

                entity.Property(e => e.Frecuencia_mensual_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Frecuencia_periodo).HasDefaultValueSql("1");

                entity.Property(e => e.Frecuencia_periodo_tipo).HasDefaultValueSql("1");

                entity.Property(e => e.Frecuencia_semanal_domingo).HasDefaultValueSql("0");

                entity.Property(e => e.Frecuencia_semanal_jueves).HasDefaultValueSql("0");

                entity.Property(e => e.Frecuencia_semanal_lunes).HasDefaultValueSql("1");

                entity.Property(e => e.Frecuencia_semanal_martes).HasDefaultValueSql("0");

                entity.Property(e => e.Frecuencia_semanal_miercoles).HasDefaultValueSql("0");

                entity.Property(e => e.Frecuencia_semanal_sabado).HasDefaultValueSql("0");

                entity.Property(e => e.Frecuencia_semanal_semanas).HasDefaultValueSql("1");

                entity.Property(e => e.Frecuencia_semanal_viernes).HasDefaultValueSql("0");

                entity.Property(e => e.Frecuencia_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Frecuencia_unica_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Idioma)
                    .HasColumnType("nchar(10)")
                    .HasDefaultValueSql("N'Español'");

                entity.Property(e => e.Sujeto).HasColumnType("nchar(200)");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.EstadisticaNavigation)
                    .WithMany(p => p.Scheduler_configuracion)
                    .HasForeignKey(d => d.Estadistica)
                    .HasConstraintName("FK_Sheduling_Estadisticas");

                entity.HasOne(d => d.InformeNavigation)
                    .WithMany(p => p.Scheduler_configuracion)
                    .HasForeignKey(d => d.Informe)
                    .HasConstraintName("FK_Sheduling_Informes");
            });

            modelBuilder.Entity<Scheduler_destinatarios>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Scheduler_configuracion_envios");

                entity.ToTable("Scheduler_destinatarios", "General");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.HasOne(d => d.SchedulerNavigation)
                    .WithMany(p => p.Scheduler_destinatarios)
                    .HasForeignKey(d => d.Scheduler)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Scheduler_configuracion_envios_Scheduler_configuracion");
            });

            modelBuilder.Entity<Scheduler_log>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Scheduler_log");

                entity.ToTable("Scheduler_log", "General");

                entity.Property(e => e.Descripcion).HasMaxLength(1000);

                entity.Property(e => e.Error).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.SchedulerNavigation)
                    .WithMany(p => p.Scheduler_log)
                    .HasForeignKey(d => d.Scheduler)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Scheduler_log_Scheduler_configuracion");
            });

            modelBuilder.Entity<Scheduler_parameters>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Sheduling_parameters");

                entity.ToTable("Scheduler_parameters", "General");

                entity.Property(e => e.Parametro).HasMaxLength(50);

                entity.Property(e => e.Valor).HasMaxLength(2000);

                entity.HasOne(d => d.SchedulerNavigation)
                    .WithMany(p => p.Scheduler_parameters)
                    .HasForeignKey(d => d.Scheduler)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Sheduling_parameters_Sheduling");
            });

            modelBuilder.Entity<Secciones_contables>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Proveedores_secciones");

                entity.ToTable("Secciones_contables", "Analitica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Area).HasColumnType("nchar(2)");

                entity.Property(e => e.Asignacion).HasColumnType("nchar(10)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Cuenta).HasColumnType("nchar(9)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Tipo).HasColumnType("nchar(2)");
            });

            modelBuilder.Entity<Seguridad_conceptos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Seguridad_conceptos");

                entity.ToTable("Seguridad_conceptos", "General");

                entity.Property(e => e.Coordenada).HasColumnType("nchar(10)");

                entity.Property(e => e.Valor).HasColumnType("nchar(10)");

                entity.HasOne(d => d.GrupoNavigation)
                    .WithMany(p => p.Seguridad_conceptos)
                    .HasForeignKey(d => d.Grupo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Seguridad_conceptos_Seguridad_grupos");
            });

            modelBuilder.Entity<Seguridad_grupos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Seguridad_grupos");

                entity.ToTable("Seguridad_grupos", "General");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Sentencia_sql_ejemplos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Sentencia_sql_ejemplos");

                entity.ToTable("Sentencia_sql_ejemplos", "General");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Servicios>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Servicios");

                entity.ToTable("Servicios", "General");

                entity.Property(e => e.Activo).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(400);

                entity.Property(e => e.Fecha_ultima_ejecucion).HasColumnType("smalldatetime");

                entity.Property(e => e.Metodo).HasMaxLength(200);

                entity.Property(e => e.Tiempo_proceso).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Simulaciones>(entity =>
            {
                entity.HasKey(e => e.Simulacion)
                    .HasName("PK_Simulaciones");

                entity.ToTable("Simulaciones", "Produccion");

                entity.Property(e => e.Descripcion).HasMaxLength(100);

                entity.Property(e => e.Fecha)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<Soldadura>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Soldadura");

                entity.ToTable("Soldadura", "Planificacion");

                entity.Property(e => e.Referencia).HasMaxLength(20);
            });

            modelBuilder.Entity<Talleres>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Talleres");

                entity.ToTable("Talleres", "Gestion");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Bloqueo_informacion).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_operaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Clave1).HasMaxLength(20);

                entity.Property(e => e.Clave2).HasMaxLength(20);

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Cliente_asociado).HasColumnType("nchar(6)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Fecha_alta)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Ftp).HasMaxLength(100);

                entity.Property(e => e.Grafico).HasMaxLength(50);

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Numero).HasDefaultValueSql("0");

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Telefono3).HasMaxLength(30);

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);
            });

            modelBuilder.Entity<Talleres_departamentos>(entity =>
            {
                entity.HasKey(e => new { e.Taller, e.Tipo_departamento })
                    .HasName("PK_Talleres_departamentos");

                entity.ToTable("Talleres_departamentos", "Gestion");

                entity.Property(e => e.Taller).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo_departamento).HasColumnType("nchar(2)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.HasOne(d => d.TallerNavigation)
                    .WithMany(p => p.Talleres_departamentos)
                    .HasForeignKey(d => d.Taller)
                    .HasConstraintName("FK_Talleres_departamentos_Talleres");

                entity.HasOne(d => d.Tipo_departamentoNavigation)
                    .WithMany(p => p.Talleres_departamentos)
                    .HasForeignKey(d => d.Tipo_departamento)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Talleres_departamentos_Departamentos_tipos");
            });

            modelBuilder.Entity<Talleres_visitas>(entity =>
            {
                entity.HasKey(e => new { e.Taller, e.Visita })
                    .HasName("PK_Talleres_visitas");

                entity.ToTable("Talleres_visitas", "Gestion");

                entity.Property(e => e.Taller).HasColumnType("nchar(6)");

                entity.Property(e => e.Visita)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.TallerNavigation)
                    .WithMany(p => p.Talleres_visitas)
                    .HasForeignKey(d => d.Taller)
                    .HasConstraintName("FK_Talleres_visitas_Talleres");
            });

            modelBuilder.Entity<Tipo_cargas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Tipo_cargas");

                entity.ToTable("Tipo_cargas", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Tiempo)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Tipos_confirming>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_tipos_confirming");

                entity.ToTable("Tipos_confirming", "Financiera");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Trabajos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ordenes_trabajo_fases");

                entity.ToTable("Trabajos", "Produccion");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(6)");

                entity.Property(e => e.Centro_trabajo).HasColumnType("nchar(6)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Fecha_alta)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_ultima_modificacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Trabajos_centros>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Trabajos_centros");

                entity.ToTable("Trabajos_centros", "Produccion");

                entity.Property(e => e.Centro_trabajo)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_transaccion).HasColumnType("smalldatetime");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Trabajos_personal>(entity =>
            {
                entity.HasKey(e => e.Trabajo)
                    .HasName("PK_Trabajos_personal");

                entity.ToTable("Trabajos_personal", "Produccion");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Fecha_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_inicio)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_transaccion).HasColumnType("smalldatetime");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.Personal)
                    .IsRequired()
                    .HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Transportes_salidas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Transportes_salidas");

                entity.ToTable("Transportes_salidas", "Logistica");

                entity.HasIndex(e => new { e.Matricula, e.Salida })
                    .HasName("Idx_MatriculaSalida")
                    .IsUnique();

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Salida).IsRequired();

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Verificada).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Transportistas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Agencias_transporte");

                entity.ToTable("Transportistas", "Logistica");

                entity.Property(e => e.Codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Bloqueo_informacion).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_operaciones).HasDefaultValueSql("0");

                entity.Property(e => e.Clave1).HasMaxLength(20);

                entity.Property(e => e.Clave2).HasMaxLength(20);

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Comunidad).HasMaxLength(50);

                entity.Property(e => e.Cpais).HasColumnType("nchar(2)");

                entity.Property(e => e.Cpostal).HasColumnType("nchar(5)");

                entity.Property(e => e.Direccion).HasMaxLength(200);

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Email1).HasMaxLength(100);

                entity.Property(e => e.Email2).HasMaxLength(100);

                entity.Property(e => e.Empresa).HasMaxLength(50);

                entity.Property(e => e.Fax1).HasMaxLength(30);

                entity.Property(e => e.Fax2).HasMaxLength(30);

                entity.Property(e => e.Fecha_alta).HasColumnType("smalldatetime");

                entity.Property(e => e.Ftp).HasMaxLength(100);

                entity.Property(e => e.Grafico).HasMaxLength(50);

                entity.Property(e => e.Horario_descarga1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_descarga2).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina1).HasColumnType("nchar(5)");

                entity.Property(e => e.Horario_oficina2).HasColumnType("nchar(5)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Internet).HasMaxLength(100);

                entity.Property(e => e.Movil1).HasMaxLength(30);

                entity.Property(e => e.Movil2).HasMaxLength(30);

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Nombre).HasMaxLength(50);

                entity.Property(e => e.Numero).HasDefaultValueSql("0");

                entity.Property(e => e.Pais).HasMaxLength(50);

                entity.Property(e => e.Poblacion).HasMaxLength(50);

                entity.Property(e => e.Provincia).HasMaxLength(50);

                entity.Property(e => e.Telefono1).HasMaxLength(30);

                entity.Property(e => e.Telefono2).HasMaxLength(30);

                entity.Property(e => e.Telefono3).HasMaxLength(30);

                entity.Property(e => e.Usuario).HasColumnType("nchar(20)");

                entity.Property(e => e.Vacaciones_final).HasColumnType("nchar(5)");

                entity.Property(e => e.Vacaciones_inicio).HasColumnType("nchar(5)");

                entity.Property(e => e.Voip1).HasMaxLength(100);

                entity.Property(e => e.Voip2).HasMaxLength(100);

                entity.Property(e => e.Zona).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Transportistas_departamentos>(entity =>
            {
                entity.HasKey(e => new { e.Transportista, e.Tipo_departamento })
                    .HasName("PK_Transportistas_departamentos");

                entity.ToTable("Transportistas_departamentos", "Logistica");

                entity.Property(e => e.Transportista).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo_departamento).HasColumnType("nchar(2)");

                entity.Property(e => e.Observaciones).HasColumnType("ntext");

                entity.Property(e => e.Persona_contacto).HasMaxLength(50);

                entity.HasOne(d => d.TransportistaNavigation)
                    .WithMany(p => p.Transportistas_departamentos)
                    .HasForeignKey(d => d.Transportista)
                    .HasConstraintName("FK_Transportistas_departamentos_Transportistas");
            });

            modelBuilder.Entity<Transportistas_evaluacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Trasportistas_evaluacion");

                entity.ToTable("Transportistas_evaluacion", "Calidad");

                entity.Property(e => e.Colaboracion).HasColumnType("nchar(2)");

                entity.Property(e => e.Fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Hora_llamada).HasColumnType("smalldatetime");

                entity.Property(e => e.Hora_llegada).HasColumnType("smalldatetime");

                entity.Property(e => e.Transportista).HasColumnType("nchar(6)");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.Property(e => e.Valoracion).HasColumnType("nchar(2)");

                entity.HasOne(d => d.ColaboracionNavigation)
                    .WithMany(p => p.Transportistas_evaluacion)
                    .HasForeignKey(d => d.Colaboracion)
                    .HasConstraintName("FK_Trasportistas_evaluacion_Valoracion_colaboracion");

                entity.HasOne(d => d.TransportistaNavigation)
                    .WithMany(p => p.Transportistas_evaluacion)
                    .HasForeignKey(d => d.Transportista)
                    .HasConstraintName("FK_Transportistas_evaluacion_Agencias_transporte");

                entity.HasOne(d => d.ValoracionNavigation)
                    .WithMany(p => p.Transportistas_evaluacion)
                    .HasForeignKey(d => d.Valoracion)
                    .HasConstraintName("FK_Trasportistas_evaluacion_Valoracion_transporte");
            });

            modelBuilder.Entity<Transportistas_matriculas>(entity =>
            {
                entity.HasKey(e => new { e.Transportista, e.Matricula })
                    .HasName("PK_Interlocutores_matriculas_1");

                entity.ToTable("Transportistas_matriculas", "Logistica");

                entity.Property(e => e.Transportista).HasColumnType("nchar(6)");

                entity.Property(e => e.Matricula).HasColumnType("nchar(10)");

                entity.HasOne(d => d.TransportistaNavigation)
                    .WithMany(p => p.Transportistas_matriculas)
                    .HasForeignKey(d => d.Transportista)
                    .HasConstraintName("FK_Transportistas_matriculas_Transportistas");
            });

            modelBuilder.Entity<Transportistas_visitas>(entity =>
            {
                entity.HasKey(e => new { e.Transportista, e.Visita })
                    .HasName("PK_Transportistas_visitas");

                entity.ToTable("Transportistas_visitas", "Logistica");

                entity.Property(e => e.Transportista).HasColumnType("nchar(6)");

                entity.Property(e => e.Visita)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.HasOne(d => d.TransportistaNavigation)
                    .WithMany(p => p.Transportistas_visitas)
                    .HasForeignKey(d => d.Transportista)
                    .HasConstraintName("FK_Transportistas_visitas_Transportistas");
            });

            modelBuilder.Entity<Traspaso_maquinas_autoexpendedoras>(entity =>
            {
                entity.HasKey(e => new { e.Maquina, e.Fecha })
                    .HasName("PK_Traspaso_vending");

                entity.ToTable("Traspaso_maquinas_autoexpendedoras", "Logistica");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<Troqueles>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Troqueles");

                entity.ToTable("Troqueles", "Matriceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(20)");

                entity.Property(e => e.Activo).HasDefaultValueSql("1");

                entity.Property(e => e.Alto).HasDefaultValueSql("0");

                entity.Property(e => e.Ancho).HasDefaultValueSql("0");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo_barras).HasColumnType("nchar(20)");

                entity.Property(e => e.Color).HasColumnType("nchar(3)");

                entity.Property(e => e.Componente).HasColumnType("nchar(2)");

                entity.Property(e => e.Cuenta).HasColumnType("nchar(20)");

                entity.Property(e => e.Descripcion).HasMaxLength(250);

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Estado).HasColumnType("nchar(2)");

                entity.Property(e => e.Fecha_alta).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_construccion).HasColumnType("smalldatetime");

                entity.Property(e => e.Funcion).HasColumnType("nchar(2)");

                entity.Property(e => e.Grafico).HasMaxLength(100);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Largo).HasDefaultValueSql("0");

                entity.Property(e => e.Mano).HasMaxLength(50);

                entity.Property(e => e.Marca).HasColumnType("nchar(4)");

                entity.Property(e => e.Modelo).HasColumnType("nchar(4)");

                entity.Property(e => e.Orden_trabajo).HasMaxLength(50);

                entity.Property(e => e.Origen).HasColumnType("nchar(6)");

                entity.Property(e => e.Peso).HasDefaultValueSql("0");

                entity.Property(e => e.Peso_base_inferior).HasDefaultValueSql("0");

                entity.Property(e => e.Peso_base_superior).HasDefaultValueSql("0");

                entity.Property(e => e.Pieza).HasColumnType("nchar(2)");

                entity.Property(e => e.Porcentaje_peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Posicion).HasColumnType("nchar(1)");

                entity.Property(e => e.Precio_adquisicion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia_auxiliar).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo_funcion).HasColumnType("nchar(3)");

                entity.Property(e => e.Ubicacion_externa).HasColumnType("nchar(6)");

                entity.Property(e => e.Ubicacion_interna).HasColumnType("nchar(6)");

                entity.HasOne(d => d.FuncionNavigation)
                    .WithMany(p => p.Troqueles)
                    .HasForeignKey(d => d.Funcion)
                    .HasConstraintName("FK_Troqueles_Troqueles_funcion");

                entity.HasOne(d => d.PosicionNavigation)
                    .WithMany(p => p.Troqueles)
                    .HasForeignKey(d => d.Posicion)
                    .HasConstraintName("FK_Troqueles_Posiciones");

                entity.HasOne(d => d.Tipo_funcionNavigation)
                    .WithMany(p => p.Troqueles)
                    .HasForeignKey(d => d.Tipo_funcion)
                    .HasConstraintName("FK_Troqueles_Troqueles_tipos_funcion1");
            });

            modelBuilder.Entity<Troqueles_articulos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Troqueles_articulos");

                entity.ToTable("Troqueles_articulos", "Matriceria");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Troquel)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.HasOne(d => d.TroquelNavigation)
                    .WithMany(p => p.Troqueles_articulos)
                    .HasForeignKey(d => d.Troquel)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Troqueles_articulos_Troqueles");
            });

            modelBuilder.Entity<Troqueles_articulos_proveedores>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Troqueles_articulos_proveedores");

                entity.ToTable("Troqueles_articulos_proveedores", "Matriceria");

                entity.HasIndex(e => new { e.Articulo, e.Troquel })
                    .HasName("Idx_ArticuloTroquel")
                    .IsUnique();

                entity.Property(e => e.Articulo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Coste)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_compra).HasColumnType("smalldatetime");

                entity.Property(e => e.Identificacion).HasColumnType("varchar(50)");

                entity.Property(e => e.Interlocutor).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo).HasColumnType("char(2)");

                entity.Property(e => e.Troquel)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Troqueles_articulos_proveedores)
                    .HasForeignKey(d => d.Articulo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Troqueles_articulos_proveedores_Articulos");
            });

            modelBuilder.Entity<Troqueles_empresas>(entity =>
            {
                entity.HasKey(e => new { e.Codigo_proveedor, e.Codigo_troquel })
                    .HasName("PK_Troqueles_empresas");

                entity.ToTable("Troqueles_empresas", "Matriceria");

                entity.Property(e => e.Codigo_proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Codigo_troquel).HasColumnType("nchar(20)");

                entity.Property(e => e.Porcentaje).HasDefaultValueSql("0");

                entity.HasOne(d => d.Codigo_proveedorNavigation)
                    .WithMany(p => p.Troqueles_empresas)
                    .HasForeignKey(d => d.Codigo_proveedor)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Troqueles_empresas_proveedores");

                entity.HasOne(d => d.Codigo_troquelNavigation)
                    .WithMany(p => p.Troqueles_empresas)
                    .HasForeignKey(d => d.Codigo_troquel)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Troqueles_empresas_Troqueles");
            });

            modelBuilder.Entity<Troqueles_funcion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_funcion");

                entity.ToTable("Troqueles_funcion", "Matriceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(30);
            });

            modelBuilder.Entity<Troqueles_imagenes>(entity =>
            {
                entity.HasKey(e => e.Codaux)
                    .HasName("IX_Troqueles_imagenes");

                entity.ToTable("Troqueles_imagenes", "Matriceria");

                entity.Property(e => e.Codigo)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Troqueles_imagenes)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Troqueles_imagenes_Troqueles");
            });

            modelBuilder.Entity<Troqueles_inventario>(entity =>
            {
                entity.HasKey(e => e.Troquel)
                    .HasName("PK_Troqueles_inventario");

                entity.ToTable("Troqueles_inventario", "Matriceria");

                entity.Property(e => e.Troquel).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Marca).HasColumnType("nchar(4)");

                entity.Property(e => e.Modelo).HasColumnType("nchar(5)");

                entity.Property(e => e.Origen).HasColumnType("nchar(6)");

                entity.Property(e => e.Precio_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.Property(e => e.Valor)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.TroquelNavigation)
                    .WithOne(p => p.Troqueles_inventario)
                    .HasForeignKey<Troqueles_inventario>(d => d.Troquel)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Troqueles_inventario_Troqueles");
            });

            modelBuilder.Entity<Troqueles_mantenimiento>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Troqueles_mantenimiento");

                entity.ToTable("Troqueles_mantenimiento", "Matriceria");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Concepto).HasColumnType("nchar(3)");

                entity.Property(e => e.Conservacion).HasDefaultValueSql("0");

                entity.Property(e => e.Coste_materiales)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion_averia).HasMaxLength(2000);

                entity.Property(e => e.Descripcion_causas).HasMaxLength(2000);

                entity.Property(e => e.Descripcion_intervencion).HasMaxLength(2000);

                entity.Property(e => e.Descripcion_propuesta).HasMaxLength(2000);

                entity.Property(e => e.Engrase).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_mantenimiento).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_solicitud)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Horas).HasDefaultValueSql("0");

                entity.Property(e => e.Limpieza).HasDefaultValueSql("0");

                entity.Property(e => e.Pepitas).HasDefaultValueSql("0");

                entity.Property(e => e.Personal).HasColumnType("nchar(5)");

                entity.Property(e => e.Plazo_entrega).HasColumnType("smalldatetime");

                entity.Property(e => e.Presupuesto)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Responsable).HasColumnType("nchar(5)");

                entity.Property(e => e.Troquel).HasColumnType("nchar(20)");

                entity.Property(e => e.Verificacion).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Troqueles_mantenimiento_conceptos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Conceptos");

                entity.ToTable("Troqueles_mantenimiento_conceptos", "Matriceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);
            });

            modelBuilder.Entity<Troqueles_movimientos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Troqueles_movimientos_1");

                entity.ToTable("Troqueles_movimientos", "Matriceria");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion_movimiento).HasColumnType("nchar(50)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Proveedor).HasColumnType("nchar(6)");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnType("nchar(2)");

                entity.Property(e => e.Troquel).HasColumnType("nchar(20)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.HasOne(d => d.TipoNavigation)
                    .WithMany(p => p.Troqueles_movimientos)
                    .HasForeignKey(d => d.Tipo)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Troqueles_movimientos_Troqueles_tipos_movimientos");

                entity.HasOne(d => d.TroquelNavigation)
                    .WithMany(p => p.Troqueles_movimientos)
                    .HasForeignKey(d => d.Troquel)
                    .HasConstraintName("FK_Troqueles_movimientos_Troqueles");
            });

            modelBuilder.Entity<Troqueles_stocks>(entity =>
            {
                entity.HasKey(e => e.Troquel)
                    .HasName("PK_Troqueles_stocks");

                entity.ToTable("Troqueles_stocks", "Matriceria");

                entity.Property(e => e.Troquel).HasColumnType("nchar(20)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Interlocutor).HasColumnType("nchar(6)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.HasOne(d => d.TroquelNavigation)
                    .WithOne(p => p.Troqueles_stocks)
                    .HasForeignKey<Troqueles_stocks>(d => d.Troquel)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Troqueles_stocks_Troqueles");
            });

            modelBuilder.Entity<Troqueles_tipos_funcion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Tipos_funcion");

                entity.ToTable("Troqueles_tipos_funcion", "Matriceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");

                entity.Property(e => e.Observaciones).HasMaxLength(2000);
            });

            modelBuilder.Entity<Troqueles_tipos_movimientos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Troqueles_tipos_movimientos");

                entity.ToTable("Troqueles_tipos_movimientos", "Matriceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Observaciones).HasMaxLength(50);
            });

            modelBuilder.Entity<Utiles>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles");

                entity.ToTable("Utiles", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(25)");

                entity.Property(e => e.Codigo_barras).HasColumnType("nchar(20)");

                entity.Property(e => e.Color).HasColumnType("nchar(3)");

                entity.Property(e => e.Componente).HasColumnType("nchar(40)");

                entity.Property(e => e.Estado).HasMaxLength(50);

                entity.Property(e => e.Fecha_edicion).HasColumnType("smalldatetime");

                entity.Property(e => e.Funcion).HasColumnType("nchar(30)");

                entity.Property(e => e.Grafico).HasMaxLength(100);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Mano).HasMaxLength(50);

                entity.Property(e => e.Marca_vehiculo).HasColumnType("nchar(25)");

                entity.Property(e => e.Modelo_vehiculo).HasColumnType("nchar(30)");

                entity.Property(e => e.Orden_trabajo).HasMaxLength(50);

                entity.Property(e => e.Origen).HasMaxLength(50);

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_base_inferior)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_base_superior)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pieza).HasColumnType("nchar(30)");

                entity.Property(e => e.Propiedad).HasMaxLength(50);

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.Property(e => e.Zona).HasMaxLength(50);
            });

            modelBuilder.Entity<Utiles_conjunto>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_conjunto");

                entity.ToTable("Utiles_conjunto", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(25)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Medios).HasColumnType("nchar(25)");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Util).HasColumnType("nchar(25)");

                entity.Property(e => e.Ver).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Utiles_control>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_control");

                entity.ToTable("Utiles_control", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(25)");

                entity.Property(e => e.Alto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Codigo_barras).HasColumnType("nchar(20)");

                entity.Property(e => e.Color).HasColumnType("nchar(3)");

                entity.Property(e => e.Componente).HasColumnType("nchar(3)");

                entity.Property(e => e.Estado).HasColumnType("nchar(2)");

                entity.Property(e => e.Fecha_edicion).HasColumnType("smalldatetime");

                entity.Property(e => e.Funcion).HasColumnType("nchar(3)");

                entity.Property(e => e.Grafico).HasMaxLength(100);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Largo)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo).HasMaxLength(50);

                entity.Property(e => e.Origen).HasColumnType("nchar(6)");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pieza).HasColumnType("nchar(3)");

                entity.Property(e => e.Propiedad).HasColumnType("nchar(6)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(6)");

                entity.Property(e => e.Vehiculo).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Utiles_cunas_posicionamiento>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_cunas_posicionamiento");

                entity.ToTable("Utiles_cunas_posicionamiento", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(25)");

                entity.Property(e => e.Activo).HasDefaultValueSql("0");

                entity.Property(e => e.Alto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ancho)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Codigo_barras).HasColumnType("nchar(20)");

                entity.Property(e => e.Color).HasColumnType("nchar(3)");

                entity.Property(e => e.Componente).HasColumnType("nchar(3)");

                entity.Property(e => e.Estado).HasColumnType("nchar(2)");

                entity.Property(e => e.Fecha_edicion).HasColumnType("smalldatetime");

                entity.Property(e => e.Funcion).HasColumnType("nchar(3)");

                entity.Property(e => e.Grafico).HasMaxLength(100);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Largo)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo).HasMaxLength(50);

                entity.Property(e => e.Origen).HasColumnType("nchar(6)");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pieza).HasColumnType("nchar(3)");

                entity.Property(e => e.Propiedad).HasColumnType("nchar(6)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.Property(e => e.Vehiculo).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Utiles_estados>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_estados");

                entity.ToTable("Utiles_estados", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");
            });

            modelBuilder.Entity<Utiles_garras>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_garras");

                entity.ToTable("Utiles_garras", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(25)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo_barras).HasColumnType("nchar(20)");

                entity.Property(e => e.Descripcion).HasMaxLength(60);
            });

            modelBuilder.Entity<Utiles_jaulas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_jaulas");

                entity.ToTable("Utiles_jaulas", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(25)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Codigo_barras).HasColumnType("nchar(20)");

                entity.Property(e => e.Descripcion).HasMaxLength(60);
            });

            modelBuilder.Entity<Utiles_piezas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_piezas");

                entity.ToTable("Utiles_piezas", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(3)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Utiles_soldar>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Utiles_soldar");

                entity.ToTable("Utiles_soldar", "Carroceria");

                entity.Property(e => e.Codigo).HasColumnType("nchar(25)");

                entity.Property(e => e.Alto).HasDefaultValueSql("0");

                entity.Property(e => e.Ancho).HasDefaultValueSql("0");

                entity.Property(e => e.Codigo_barras).HasColumnType("nchar(20)");

                entity.Property(e => e.Color).HasColumnType("nchar(3)");

                entity.Property(e => e.Componente).HasColumnType("nchar(3)");

                entity.Property(e => e.Estado).HasColumnType("nchar(2)");

                entity.Property(e => e.Fecha_edicion).HasColumnType("smalldatetime");

                entity.Property(e => e.Funcion).HasColumnType("nchar(2)");

                entity.Property(e => e.Grafico).HasMaxLength(100);

                entity.Property(e => e.Imagen).HasColumnType("image");

                entity.Property(e => e.Largo).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo).HasMaxLength(50);

                entity.Property(e => e.Origen).HasColumnType("nchar(6)");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Pieza).HasColumnType("nchar(3)");

                entity.Property(e => e.Propiedad).HasColumnType("nchar(6)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.Property(e => e.Vehiculo).HasColumnType("nchar(5)");

                entity.HasOne(d => d.FuncionNavigation)
                    .WithMany(p => p.Utiles_soldar)
                    .HasForeignKey(d => d.Funcion)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Utiles_soldar_Utiles_funcion");
            });

            modelBuilder.Entity<Valoracion_colaboracion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Valoracion_colaboracion");

                entity.ToTable("Valoracion_colaboracion", "Calidad");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);
            });

            modelBuilder.Entity<Valoracion_transporte>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Valoracion_transporte");

                entity.ToTable("Valoracion_transporte", "Calidad");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<Ventas_albaranes_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_albaranes_cabecera");

                entity.ToTable("Ventas_albaranes_cabecera", "Ventas");

                entity.HasIndex(e => e.Aprobado)
                    .HasName("Idx_Aprobado");

                entity.HasIndex(e => e.Cliente)
                    .HasName("Idx_Interlocutor");

                entity.HasIndex(e => e.Ejercicio)
                    .HasName("Idx_Ejercicio");

                entity.HasIndex(e => e.Facturado)
                    .HasName("Idx_Facturado");

                entity.HasIndex(e => e.Fecha_albaran)
                    .HasName("Idx_FechaAlbaran");

                entity.HasIndex(e => e.Modo)
                    .HasName("Idx_Modo");

                entity.HasIndex(e => new { e.Ejercicio, e.Modo })
                    .HasName("Idx_EjercicioModo");

                entity.HasIndex(e => new { e.Modo, e.Ejercicio })
                    .HasName("Idx_ModoEjercicio");

                entity.HasIndex(e => new { e.Albaran, e.Ejercicio, e.Modo })
                    .HasName("AlbaranEjercicioModo")
                    .IsUnique();

                entity.Property(e => e.Agencia_transporte).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaran)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Almacen_destino).HasColumnType("nchar(3)");

                entity.Property(e => e.Almacen_origen).HasColumnType("nchar(3)");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("0");

                entity.Property(e => e.Base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Cliente_empresa).HasMaxLength(50);

                entity.Property(e => e.Decimales_cantidad).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_precios).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_totales).HasDefaultValueSql("2");

                entity.Property(e => e.Descuento_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_pronto_pago)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_volumen)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_decimales).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_enteros).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Factor_impresion).HasColumnType("decimal");

                entity.Property(e => e.Factura_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Facturado).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_albaran)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_aprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_carga).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_entrega).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_factura).HasColumnType("smalldatetime");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Incoterm1).HasColumnType("nchar(5)");

                entity.Property(e => e.Incoterm2).HasColumnType("nchar(5)");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Licencia_importacion).HasMaxLength(50);

                entity.Property(e => e.Material_origen).HasMaxLength(50);

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones_administracion).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_almacen).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_generales).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_privadas).HasMaxLength(2000);

                entity.Property(e => e.Partida_arancelaria).HasMaxLength(50);

                entity.Property(e => e.Pedido_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Pedido_restos_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_restos_generar).HasDefaultValueSql("0");

                entity.Property(e => e.Peso_adicional)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_embalajes_externos)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_bultos).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_real)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuentos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Portes_iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_observaciones).HasMaxLength(2000);

                entity.Property(e => e.Portes_peso_bruto).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_trayecto).HasColumnType("nchar(2)");

                entity.Property(e => e.Portes_trayecto_coste)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("3");

                entity.Property(e => e.Recargo_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_financiero)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reclamacion_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Retencion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Salida).HasDefaultValueSql("0");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_pronto_pago)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_volumen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_divisa_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes_suplementos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_general)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_portes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_equivalencia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_financiero)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_retencion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Total_volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.Agencia_transporteNavigation)
                    .WithMany(p => p.Ventas_albaranes_cabecera)
                    .HasForeignKey(d => d.Agencia_transporte)
                    .HasConstraintName("FK_Ventas_albaranes_cabecera_Agencias_transporte");

                entity.HasOne(d => d.AgenteNavigation)
                    .WithMany(p => p.Ventas_albaranes_cabecera)
                    .HasForeignKey(d => d.Agente)
                    .HasConstraintName("FK_Ventas_albaranes_cabecera_Agentes");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Ventas_albaranes_cabecera)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Ventas_albaranes_cabecera_Almacen");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Ventas_albaranes_cabecera)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Ventas_albaranes_cabecera_Clientes");

                entity.HasOne(d => d.Forma_pagoNavigation)
                    .WithMany(p => p.Ventas_albaranes_cabecera)
                    .HasForeignKey(d => d.Forma_pago)
                    .HasConstraintName("FK_Ventas_albaranes_cabecera_Formas_pago");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Ventas_albaranes_cabecera)
                    .HasForeignKey(d => d.Iva)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ventas_albaranes_cabecera_Ivas");
            });

            modelBuilder.Entity<Ventas_albaranes_carga>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Albaranes_carga");

                entity.ToTable("Ventas_albaranes_carga", "Picking");

                entity.HasIndex(e => e.Albaran)
                    .HasName("Idx_albaran");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_articulo");

                entity.HasIndex(e => e.Contenedor)
                    .HasName("Idx_contenedor");

                entity.HasIndex(e => e.Fecha_entrada)
                    .HasName("Idx_fecha_carga");

                entity.HasIndex(e => e.Fecha_salida)
                    .HasName("Idx_fecha_salida");

                entity.HasIndex(e => e.Jaula)
                    .HasName("Idx_jaula");

                entity.HasIndex(e => e.Matricula)
                    .HasName("Idx_matricula");

                entity.HasIndex(e => e.Orden_salida)
                    .HasName("Idx_orden_salida");

                entity.HasIndex(e => e.Procesada)
                    .HasName("Idx_procesada");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Completar).HasColumnType("nchar(1)");

                entity.Property(e => e.Contenedor).HasColumnType("nchar(14)");

                entity.Property(e => e.Destino).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_entrada)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_salida).HasColumnType("smalldatetime");

                entity.Property(e => e.Introduccion).HasColumnType("nchar(1)");

                entity.Property(e => e.Jaula).HasColumnType("nchar(10)");

                entity.Property(e => e.Matricula).HasColumnType("nchar(10)");

                entity.Property(e => e.Medida).HasColumnType("nchar(1)");

                entity.Property(e => e.Orden).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_carga).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_salida).HasDefaultValueSql("0");

                entity.Property(e => e.Precinto).HasColumnType("nchar(14)");

                entity.Property(e => e.Procesada).HasDefaultValueSql("0");

                entity.Property(e => e.Repeticion).HasColumnType("nchar(1)");

                entity.Property(e => e.Reservado).HasDefaultValueSql("0");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.HasOne(d => d.AlbaranNavigation)
                    .WithMany(p => p.Ventas_albaranes_carga)
                    .HasForeignKey(d => d.Albaran)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ventas_albaranes_carga_Albaranes_cabecera");

                entity.HasOne(d => d.Albaran_numero_lineaNavigation)
                    .WithMany(p => p.Ventas_albaranes_carga)
                    .HasForeignKey(d => d.Albaran_numero_linea)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ventas_albaranes_carga_Albaranes_detalle");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Ventas_albaranes_carga)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Ventas_albaranes_carga_Articulos");
            });

            modelBuilder.Entity<Ventas_albaranes_carga_historico>(entity =>
            {
                entity.HasKey(e => e.Transaccion)
                    .HasName("PK_Ventas_albaranes_carga_historico");

                entity.ToTable("Ventas_albaranes_carga_historico", "Picking");

                entity.HasIndex(e => e.Albaran_numero_linea)
                    .HasName("Idx_AlbaranNumeroLinea");

                entity.HasIndex(e => e.Codigo)
                    .HasName("Idx_codigo");

                entity.Property(e => e.Actualizacion).HasDefaultValueSql("0");

                entity.Property(e => e.Albaran).HasDefaultValueSql("0");

                entity.Property(e => e.Albaran_numero_linea).HasDefaultValueSql("0");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Completar).HasColumnType("nchar(1)");

                entity.Property(e => e.Contenedor).HasColumnType("nchar(14)");

                entity.Property(e => e.Destino).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_entrada).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_salida).HasColumnType("smalldatetime");

                entity.Property(e => e.Introduccion).HasColumnType("nchar(1)");

                entity.Property(e => e.Jaula).HasColumnType("nchar(10)");

                entity.Property(e => e.Matricula).HasColumnType("nchar(10)");

                entity.Property(e => e.Medida).HasColumnType("nchar(1)");

                entity.Property(e => e.Orden).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_carga).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_salida).HasDefaultValueSql("0");

                entity.Property(e => e.Precinto).HasColumnType("nchar(14)");

                entity.Property(e => e.Repeticion).HasColumnType("nchar(1)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");
            });

            modelBuilder.Entity<Ventas_albaranes_carga_operarios>(entity =>
            {
                entity.HasKey(e => new { e.Albaran, e.Jaula, e.Operario })
                    .HasName("PK_Ventas_albaranes_carga_operarios");

                entity.ToTable("Ventas_albaranes_carga_operarios", "Picking");

                entity.HasIndex(e => e.Jaula)
                    .HasName("Idx_jaula");

                entity.Property(e => e.Jaula).HasColumnType("nchar(10)");

                entity.Property(e => e.Operario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.AlbaranNavigation)
                    .WithMany(p => p.Ventas_albaranes_carga_operarios)
                    .HasForeignKey(d => d.Albaran)
                    .HasConstraintName("FK_Ventas_albaranes_carga_usuarios_Albaranes_cabecera");

                entity.HasOne(d => d.OperarioNavigation)
                    .WithMany(p => p.Ventas_albaranes_carga_operarios)
                    .HasForeignKey(d => d.Operario)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ventas_albaranes_carga_operarios_Personal");
            });

            modelBuilder.Entity<Ventas_albaranes_carga_salidas>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_albaranes_carga_salidas");

                entity.ToTable("Ventas_albaranes_carga_salidas", "Picking");

                entity.HasIndex(e => e.Albaran)
                    .HasName("Idx_Albaran");

                entity.HasIndex(e => new { e.Albaran, e.Salida })
                    .HasName("Idx_AlbaranSalida")
                    .IsUnique();

                entity.HasIndex(e => new { e.Albaran, e.Matricula, e.Contenedor, e.Salida })
                    .HasName("Idx_AlbaranMatriculaContenedorSalida")
                    .IsUnique();

                entity.Property(e => e.Cajas).HasDefaultValueSql("0");

                entity.Property(e => e.Canchadas).HasDefaultValueSql("0");

                entity.Property(e => e.Contenedor)
                    .IsRequired()
                    .HasColumnType("char(14)");

                entity.Property(e => e.Coste)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Hora_final).HasColumnType("smalldatetime");

                entity.Property(e => e.Hora_inicio).HasColumnType("smalldatetime");

                entity.Property(e => e.Hora_salida).HasColumnType("smalldatetime");

                entity.Property(e => e.Jaulas).HasDefaultValueSql("0");

                entity.Property(e => e.Matricula)
                    .IsRequired()
                    .HasColumnType("char(10)");

                entity.Property(e => e.Palets).HasDefaultValueSql("0");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_bruto_adicional)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_embalajes)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precinto).HasColumnType("char(14)");

                entity.Property(e => e.Salida).IsRequired();

                entity.Property(e => e.Transporte_tipo).HasColumnType("char(10)");

                entity.Property(e => e.Unidades)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AlbaranNavigation)
                    .WithMany(p => p.Ventas_albaranes_carga_salidas)
                    .HasForeignKey(d => d.Albaran)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ventas_albaranes_carga_salidas_Albaranes_cabecera");
            });

            modelBuilder.Entity<Ventas_albaranes_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Ventas_albaranes_detalle");

                entity.ToTable("Ventas_albaranes_detalle", "Ventas");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_Articulo");

                entity.HasIndex(e => e.Bloqueada)
                    .HasName("Idx_Bloqueada");

                entity.HasIndex(e => e.Codigo)
                    .HasName("Idx_Codigo");

                entity.HasIndex(e => e.Factura_numero_linea)
                    .HasName("Idx_FacturaNumeroLinea");

                entity.HasIndex(e => e.Stocks)
                    .HasName("Idx_Stocks");

                entity.HasIndex(e => new { e.Numero, e.Almacen })
                    .HasName("_dta_index_Ventas_albaranes_detalle_11_300905235__K1_K6");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Descuento)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Etiqueta).HasColumnType("nchar(3)");

                entity.Property(e => e.Factura_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Factura_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Minimo_precio_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo).HasColumnType("nchar(20)");

                entity.Property(e => e.Pedidas).HasDefaultValueSql("0");

                entity.Property(e => e.Pedido_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Pendientes)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_etiqueta)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Reclamacion_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Stocks).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_precio).HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_linea)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_re)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Ventas_albaranes_detalle)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Ventas_albaranes_detalle_Articulos");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Ventas_albaranes_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ventas_albaranes_detalle_Ventas_albaranes_cabecera");
            });

            modelBuilder.Entity<Ventas_albaranes_detalle_ubicaciones>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Albaranes_detalle_ubicaciones");

                entity.ToTable("Ventas_albaranes_detalle_ubicaciones", "Ventas");

                entity.HasIndex(e => e.Albaran_numero_linea)
                    .HasName("Idx_albaranNumeroLinea");

                entity.HasIndex(e => new { e.Ubicacion, e.Albaran_numero_linea, e.Codigo })
                    .HasName("_dta_index_Ventas_albaranes_detalle_ubicaci_11_1611686081__K3_K1_6");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Ubicacion).HasColumnType("nchar(5)");

                entity.HasOne(d => d.Albaran_numero_lineaNavigation)
                    .WithMany(p => p.Ventas_albaranes_detalle_ubicaciones)
                    .HasForeignKey(d => d.Albaran_numero_linea)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Albaranes_detalle_ubicaciones_Albaranes_detalle");
            });

            modelBuilder.Entity<Ventas_albaranes_embalajes>(entity =>
            {
                entity.HasKey(e => new { e.Albaran, e.Embalaje })
                    .HasName("PK_Albaranes_embalajes");

                entity.ToTable("Ventas_albaranes_embalajes", "Ventas");

                entity.Property(e => e.Embalaje).HasColumnType("nchar(3)");

                entity.Property(e => e.Calculo).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AlbaranNavigation)
                    .WithMany(p => p.Ventas_albaranes_embalajes)
                    .HasForeignKey(d => d.Albaran)
                    .HasConstraintName("FK_Ventas_albaranes_embalajes_Ventas_albaranes_cabecera");

                entity.HasOne(d => d.EmbalajeNavigation)
                    .WithMany(p => p.Ventas_albaranes_embalajes)
                    .HasForeignKey(d => d.Embalaje)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ventas_albaranes_embalajes_Embalajes");
            });

            modelBuilder.Entity<Ventas_documentacion_facturacion>(entity =>
            {
                entity.HasKey(e => e.Factura)
                    .HasName("PK_Ventas_documentacion_facturacion");

                entity.ToTable("Ventas_documentacion_facturacion", "Ventas");

                entity.Property(e => e.Factura).ValueGeneratedNever();

                entity.Property(e => e.Bl).HasDefaultValueSql("0");

                entity.Property(e => e.Bl_enviar_completo).HasDefaultValueSql("0");

                entity.Property(e => e.Bl_enviar_originales).HasDefaultValueSql("0");

                entity.Property(e => e.Certificado_origen).HasDefaultValueSql("0");

                entity.Property(e => e.Certificado_origen_camara).HasDefaultValueSql("0");

                entity.Property(e => e.Certificado_origen_embajada).HasDefaultValueSql("0");

                entity.Property(e => e.Certificado_origen_embajada_nombre).HasColumnType("varchar(50)");

                entity.Property(e => e.Certificado_origen_empresa).HasDefaultValueSql("0");

                entity.Property(e => e.Cmr).HasDefaultValueSql("0");

                entity.Property(e => e.Cmr_Transfin).HasDefaultValueSql("0");

                entity.Property(e => e.Cmr_Virgili).HasDefaultValueSql("0");

                entity.Property(e => e.Cmr_tonoli).HasDefaultValueSql("0");

                entity.Property(e => e.Documentacion).HasColumnType("char(4)");

                entity.Property(e => e.Eur1).HasDefaultValueSql("0");

                entity.Property(e => e.Eur1_entregar).HasDefaultValueSql("0");

                entity.Property(e => e.Eur1_entregar_destino).HasColumnType("varchar(50)");

                entity.Property(e => e.Eur1_enviar_cliente).HasDefaultValueSql("0");

                entity.Property(e => e.Eur1_enviar_empresa).HasDefaultValueSql("0");

                entity.Property(e => e.Eur1_enviar_original).HasDefaultValueSql("0");

                entity.Property(e => e.Ex1).HasDefaultValueSql("0");

                entity.Property(e => e.Ex1_copia_fax).HasDefaultValueSql("0");

                entity.Property(e => e.Ex1_copia_resto).HasDefaultValueSql("0");

                entity.Property(e => e.Ex1_entregar_ejemplar).HasDefaultValueSql("0");

                entity.Property(e => e.Ex1_entregar_ejemplar_nombre).HasColumnType("varchar(50)");

                entity.Property(e => e.Ex1_enviar_empresa).HasDefaultValueSql("0");

                entity.Property(e => e.Ex1_enviar_original1).HasDefaultValueSql("0");

                entity.Property(e => e.Ex1_enviar_original2).HasDefaultValueSql("0");

                entity.Property(e => e.Ex1_retorno_original).HasDefaultValueSql("0");

                entity.Property(e => e.Factura_camara).HasDefaultValueSql("0");

                entity.Property(e => e.Factura_copia).HasDefaultValueSql("0");

                entity.Property(e => e.Factura_documento).HasDefaultValueSql("0");

                entity.Property(e => e.Factura_embajada).HasDefaultValueSql("0");

                entity.Property(e => e.Factura_embajada_nombre).HasColumnType("varchar(50)");

                entity.Property(e => e.Factura_original).HasDefaultValueSql("0");

                entity.Property(e => e.Letra).HasDefaultValueSql("0");

                entity.Property(e => e.Letra_entregar_cliente).HasDefaultValueSql("0");

                entity.Property(e => e.Observaciones).HasColumnType("varchar(4000)");

                entity.Property(e => e.Packing_list).HasDefaultValueSql("0");

                entity.Property(e => e.Seguro).HasDefaultValueSql("0");

                entity.Property(e => e.Seguro_asegurar_mercancia).HasDefaultValueSql("0");

                entity.Property(e => e.Verificada).HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Ventas_facturas_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Interlocutores_facturas_cabecera");

                entity.ToTable("Ventas_facturas_cabecera", "Ventas");

                entity.HasIndex(e => e.Aprobado)
                    .HasName("Idx_Aprobado");

                entity.HasIndex(e => e.Cliente)
                    .HasName("Idx_Interlocutor");

                entity.HasIndex(e => e.Ejercicio)
                    .HasName("Idx_Ejercicio");

                entity.HasIndex(e => e.Fecha_factura)
                    .HasName("IX_Fecha_factura");

                entity.HasIndex(e => e.Modo)
                    .HasName("Idx_Modo");

                entity.HasIndex(e => new { e.Aprobado, e.Codigo, e.Fecha_factura })
                    .HasName("_dta_index_Ventas_facturas_cabecera_11_2118167933__K18_K1_K14");

                entity.HasIndex(e => new { e.Ejercicio, e.Fecha_factura, e.Codigo })
                    .HasName("_dta_index_Ventas_facturas_cabecera_19_986694813__K1_3_6");

                entity.HasIndex(e => new { e.Factura, e.Ejercicio, e.Modo })
                    .HasName("Idx_Ejercicio_modo");

                entity.HasIndex(e => new { e.Divisa_cambio, e.Fecha_factura, e.Codigo, e.Ejercicio })
                    .HasName("_IdxCodigoEjercicio");

                entity.HasIndex(e => new { e.Fecha_factura, e.Aprobado, e.Codigo, e.Ejercicio })
                    .HasName("_dta_index_Ventas_facturas_cabecera_11_2118167933__K18_K1_K4_14");

                entity.Property(e => e.Abono_rappel).HasDefaultValueSql("0");

                entity.Property(e => e.Agencia_transporte).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente_aduanas).HasColumnType("nchar(6)");

                entity.Property(e => e.Anticipo_banco).HasColumnType("nchar(15)");

                entity.Property(e => e.Anticipo_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Anticipo_importe)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("0");

                entity.Property(e => e.Base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueo_cartera).HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_manual_peso_bruto).HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_manual_peso_neto).HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_manual_volumen).HasDefaultValueSql("0");

                entity.Property(e => e.Cesion).HasColumnType("nchar(10)");

                entity.Property(e => e.Cesion_almacen_destino).HasColumnType("nchar(3)");

                entity.Property(e => e.Cesion_almacen_origen).HasColumnType("nchar(3)");

                entity.Property(e => e.Cierre).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Cliente_empresa).HasMaxLength(50);

                entity.Property(e => e.Comision)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Comision_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Comision_pagada).HasDefaultValueSql("0");

                entity.Property(e => e.Contabilizada).HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_cantidad).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_precios).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_totales).HasDefaultValueSql("2");

                entity.Property(e => e.Descripciones).HasDefaultValueSql("0");

                entity.Property(e => e.Descripciones_valor).HasColumnType("nchar(20)");

                entity.Property(e => e.Descuento_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_pronto_pago)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_volumen)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_decimales).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_enteros).HasDefaultValueSql("0");

                entity.Property(e => e.Documentacion_verificada).HasDefaultValueSql("0");

                entity.Property(e => e.Dua_numero).HasColumnType("nchar(10)");

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Factor_impresion).HasColumnType("decimal");

                entity.Property(e => e.Factura)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Fecha_aprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_cobro).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_factura)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Incoterm1).HasColumnType("nchar(5)");

                entity.Property(e => e.Incoterm2).HasColumnType("nchar(5)");

                entity.Property(e => e.Informe_descripciones).HasDefaultValueSql("0");

                entity.Property(e => e.Informe_descripciones_valor).HasMaxLength(20);

                entity.Property(e => e.Inhabilitar_peso_por_contenedor).HasDefaultValueSql("0");

                entity.Property(e => e.Intrastat).HasDefaultValueSql("0");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Material_origen).HasMaxLength(50);

                entity.Property(e => e.Mes).HasColumnType("nchar(2)");

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones_administrativas).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_forma_pago).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_generales).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_mercancias).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_privadas).HasMaxLength(2000);

                entity.Property(e => e.Pagada).HasDefaultValueSql("0");

                entity.Property(e => e.Partida_arancelaria).HasMaxLength(50);

                entity.Property(e => e.Peso_adicional)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_embalajes_externos)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_aduanas)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_real)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_transporte)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_coste_varios)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descripcion_varios).HasMaxLength(1000);

                entity.Property(e => e.Portes_descuento_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuentos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_factura_aduanas).HasColumnType("nchar(20)");

                entity.Property(e => e.Portes_factura_transporte).HasColumnType("nchar(20)");

                entity.Property(e => e.Portes_iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Portes_iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_verificado).HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_financiero)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Registro_aduanas).HasColumnType("nchar(11)");

                entity.Property(e => e.Registro_aduanas_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Retencion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_comision)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_pronto_pago)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_volumen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_divisa_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes_suplementos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_general)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_portes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_equivalencia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_financiero)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_retencion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Total_volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.Property(e => e.Zona_iva).HasMaxLength(30);

                entity.Property(e => e.Zona_politica).HasMaxLength(30);

                entity.Property(e => e.Zona_tipo).HasMaxLength(30);

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Ventas_facturas_cabecera)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Ventas_facturas_cabecera_Clientes");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Ventas_facturas_cabecera)
                    .HasForeignKey(d => d.Iva)
                    .HasConstraintName("FK_Ventas_facturas_cabecera_Ivas");
            });

            modelBuilder.Entity<Ventas_facturas_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Interlocutores_facturas_detalle");

                entity.ToTable("Ventas_facturas_detalle", "Ventas");

                entity.HasIndex(e => e.Albaran_numero_linea)
                    .HasName("Idx_AlbaranNumeroLinea");

                entity.HasIndex(e => e.Articulo)
                    .HasName("IX_Ventas_facturas_detalle");

                entity.HasIndex(e => e.Bloqueada)
                    .HasName("Idx_Bloqueada");

                entity.HasIndex(e => e.Codigo)
                    .HasName("IX_Ventas_facturas_detalle_codigo");

                entity.HasIndex(e => e.Stocks)
                    .HasName("Idx_Stocks");

                entity.HasIndex(e => new { e.Cantidad, e.Articulo, e.Codigo, e.Almacen })
                    .HasName("_dta_index_Ventas_facturas_detalle_11_1869626845__K7_K2_K9_12");

                entity.HasIndex(e => new { e.Cantidad, e.Codigo, e.Almacen, e.Articulo })
                    .HasName("Idx_EstudioPedidos");

                entity.HasIndex(e => new { e.Cantidad, e.Codigo, e.Total_linea, e.Bloqueada, e.Numero, e.Articulo })
                    .HasName("Idx_CodigoTotalBloqueadaNumeroArticulo");

                entity.Property(e => e.Albaran_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaran_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasColumnType("varchar(200)");

                entity.Property(e => e.Descuento)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Etiqueta).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Linea).HasDefaultValueSql("0");

                entity.Property(e => e.Minimo_precio_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_etiqueta)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Stocks).HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_precio).HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_linea)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_re)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Ventas_facturas_detalle)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Ventas_facturas_detalle_Almacen");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Ventas_facturas_detalle)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Ventas_facturas_detalle_Articulos");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Ventas_facturas_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ventas_facturas_detalle_Ventas_facturas_cabecera");
            });

            modelBuilder.Entity<Ventas_facturas_embalajes>(entity =>
            {
                entity.HasKey(e => new { e.Factura, e.Embalaje })
                    .HasName("PK_Facturas_embalajes");

                entity.ToTable("Ventas_facturas_embalajes", "Ventas");

                entity.Property(e => e.Embalaje).HasColumnType("nchar(3)");

                entity.Property(e => e.Calculo).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.EmbalajeNavigation)
                    .WithMany(p => p.Ventas_facturas_embalajes)
                    .HasForeignKey(d => d.Embalaje)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ventas_facturas_embalajes_Embalajes");

                entity.HasOne(d => d.FacturaNavigation)
                    .WithMany(p => p.Ventas_facturas_embalajes)
                    .HasForeignKey(d => d.Factura)
                    .HasConstraintName("FK_Ventas_facturas_embalajes_Ventas_facturas_cabecera");
            });

            modelBuilder.Entity<Ventas_facturas_periodos_cierre>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_facturas_periodos_cierre");

                entity.ToTable("Ventas_facturas_periodos_cierre", "Ventas");

                entity.HasIndex(e => new { e.Ejercicio, e.Mes })
                    .HasName("Idx_EjercicioMes")
                    .IsUnique();

                entity.Property(e => e.Cierre).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");
            });

            modelBuilder.Entity<Ventas_indicadores_comerciales>(entity =>
            {
                entity.HasKey(e => e.Ejercicio)
                    .HasName("PK_Indicadores_comerciales");

                entity.ToTable("Ventas_indicadores_comerciales", "Ventas");

                entity.Property(e => e.Ejercicio).HasColumnType("char(4)");

                entity.Property(e => e.Avance_aletas)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Avance_capots)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Avance_frentes)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Avance_varios)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Coste_piezas_empleado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_actualizacion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Nivel_servicio_ratio)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nivel_servicio_unidades_pedidas).HasDefaultValueSql("0");

                entity.Property(e => e.Nivel_servicio_unidades_servidas).HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_aletas)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_capots)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_frentes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Objetivo_varios)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_total_aletas)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_total_capots)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_total_frentes)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje_total_varios)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencias_vivas).HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_mayor_seis_media).HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_mayor_seis_porcentaje)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_mayor_seis_referencias).HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_mayor_seis_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_menor_tres_media).HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_menor_tres_porcentaje)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_menor_tres_referencias).HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_menor_tres_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_tres_seis_media).HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_tres_seis_porcentaje)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_tres_seis_referencias).HasDefaultValueSql("0");

                entity.Property(e => e.VPiezas_tres_seis_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Venta_piezas_empleado_numero)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Venta_piezas_empleado_ratio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_exportacion_avance)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_exportacion_clientes).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_exportacion_presupuestado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_exportacion_real)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_exportacion_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_exportacion_zonas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_nacionales_avance)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_nacionales_clientes).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_nacionales_presupuestado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_nacionales_real)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_nacionales_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_nacionales_zonas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_por_referencia).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_totales_avance)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_totales_clientes).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_totales_presupuestado)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_totales_real)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_totales_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_totales_zonas).HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_unidades_aletas)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_unidades_capots)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_unidades_frentes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ventas_unidades_varios)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Ventas_pedidos_baja_rentabilidad>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_pedidos_baja_rentabilidad");

                entity.ToTable("Ventas_pedidos_baja_rentabilidad", "Ventas");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Pedido_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Rentabilidad)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Valor_piezas).HasColumnType("money");
            });

            modelBuilder.Entity<Ventas_pedidos_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_pedidos_cabecera");

                entity.ToTable("Ventas_pedidos_cabecera", "Ventas");

                entity.HasIndex(e => e.Aprobado)
                    .HasName("Idx_Aprobado");

                entity.HasIndex(e => e.Cliente)
                    .HasName("Idx_Cliente");

                entity.HasIndex(e => e.Ejercicio)
                    .HasName("Idx_Ejercicio");

                entity.HasIndex(e => e.Fecha_entrega)
                    .HasName("Idx_FechaEntrega");

                entity.HasIndex(e => e.Fecha_pedido)
                    .HasName("Idx_FechaPedido");

                entity.HasIndex(e => e.Modo)
                    .HasName("Idx_Modo");

                entity.HasIndex(e => new { e.Ejercicio, e.Modo })
                    .HasName("Idx_EjercicioModo");

                entity.HasIndex(e => new { e.Fecha_entrega, e.Aprobado, e.Codigo })
                    .HasName("_dta_index_Ventas_pedidos_cabecera_11_1161640523__K21_K1_16");

                entity.Property(e => e.Agencia_transporte).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaran_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaran_codigo_origen).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaran_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("0");

                entity.Property(e => e.Base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Cliente_empresa).HasMaxLength(50);

                entity.Property(e => e.Confirmacion_enviada).HasDefaultValueSql("0");

                entity.Property(e => e.Decimales_cantidad).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_precios).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_totales).HasDefaultValueSql("2");

                entity.Property(e => e.Descuento_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_pronto_pago)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_volumen)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_decimales).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_enteros).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Factor_impresion).HasColumnType("decimal");

                entity.Property(e => e.Fecha_aprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_carga).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_entrega).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_pedido)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Impreso).HasDefaultValueSql("0");

                entity.Property(e => e.Incoterm1).HasColumnType("nchar(5)");

                entity.Property(e => e.Incoterm2).HasColumnType("nchar(5)");

                entity.Property(e => e.Internet_bloqueado).HasDefaultValueSql("0");

                entity.Property(e => e.Internet_procesado).HasDefaultValueSql("0");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones_almacen).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_generales).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_obsequios).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_pedido).HasMaxLength(2000);

                entity.Property(e => e.Pedido).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_codigo_origen).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_enviado).HasDefaultValueSql("0");

                entity.Property(e => e.Pedido_restos_generar).HasDefaultValueSql("0");

                entity.Property(e => e.Portes_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuentos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Portes_iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_observaciones).HasMaxLength(2000);

                entity.Property(e => e.Portes_re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("3");

                entity.Property(e => e.Proforma_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Proforma_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Recargo_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_financiero)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Retencion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Salida).HasDefaultValueSql("0");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Tipo_contenedor).HasColumnType("nchar(2)");

                entity.Property(e => e.Total_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_pronto_pago)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_volumen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_divisa_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes_suplementos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_general)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_portes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_equivalencia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_financiero)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_retencion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Total_volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.Agencia_transporteNavigation)
                    .WithMany(p => p.Ventas_pedidos_cabecera)
                    .HasForeignKey(d => d.Agencia_transporte)
                    .HasConstraintName("FK_Ventas_pedidos_cabecera_Agencias_transporte");

                entity.HasOne(d => d.AgenteNavigation)
                    .WithMany(p => p.Ventas_pedidos_cabecera)
                    .HasForeignKey(d => d.Agente)
                    .HasConstraintName("FK_Ventas_pedidos_cabecera_Agentes");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Ventas_pedidos_cabecera)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Ventas_pedidos_cabecera_Clientes");

                entity.HasOne(d => d.ProformaNavigation)
                    .WithMany(p => p.Ventas_pedidos_cabecera)
                    .HasForeignKey(d => d.Proforma)
                    .HasConstraintName("FK_Ventas_pedidos_cabecera_Ventas_proformas_cabecera");
            });

            modelBuilder.Entity<Ventas_pedidos_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Ventas_pedidos_detalle");

                entity.ToTable("Ventas_pedidos_detalle", "Ventas");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Articulo");

                entity.HasIndex(e => e.Bloqueada)
                    .HasName("Aprobada");

                entity.HasIndex(e => e.Codigo)
                    .HasName("Codigo");

                entity.HasIndex(e => new { e.Codigo, e.Bloqueada, e.Completada, e.Articulo, e.Almacen, e.Pendientes })
                    .HasName("Idx_PedidosPendientes");

                entity.HasIndex(e => new { e.Servidas, e.Bloqueada, e.Completada, e.Almacen, e.Cantidad, e.Articulo, e.Codigo })
                    .HasName("_dta_index_Ventas_pedidos_detalle_11_709446893__K24_K26_K7_K9_K5_K2_10");

                entity.Property(e => e.Albaran_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaran_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Base).HasDefaultValueSql("0");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(2)");

                entity.Property(e => e.Completada).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Descuento)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Etiqueta).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Minimo_precio_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo).HasMaxLength(20);

                entity.Property(e => e.Pendientes)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_etiqueta)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Proforma_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Proforma_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Servidas)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo_precio).HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_linea)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_re)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Ventas_pedidos_detalle)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Compras_pedidos_detalle_Almacen");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Ventas_pedidos_detalle)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Pedidos_detalle_Articulos");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Ventas_pedidos_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Ventas_pedidos_detalle_Ventas_pedidos_cabecera");

                entity.HasOne(d => d.EtiquetaNavigation)
                    .WithMany(p => p.Ventas_pedidos_detalle)
                    .HasForeignKey(d => d.Etiqueta)
                    .HasConstraintName("FK_Ventas_pedidos_detalle_Embalajes");

                entity.HasOne(d => d.IvaNavigation)
                    .WithMany(p => p.Ventas_pedidos_detalle)
                    .HasForeignKey(d => d.Iva)
                    .HasConstraintName("FK_Pedidos_detalle_Ivas");
            });

            modelBuilder.Entity<Ventas_pedidos_embalajes>(entity =>
            {
                entity.HasKey(e => new { e.Pedido, e.Embalaje })
                    .HasName("PK_Pedidos_embalajes");

                entity.ToTable("Ventas_pedidos_embalajes", "Ventas");

                entity.Property(e => e.Embalaje).HasColumnType("nchar(3)");

                entity.Property(e => e.Calculo).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.EmbalajeNavigation)
                    .WithMany(p => p.Ventas_pedidos_embalajes)
                    .HasForeignKey(d => d.Embalaje)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ventas_pedidos_embalajes_Embalajes");

                entity.HasOne(d => d.PedidoNavigation)
                    .WithMany(p => p.Ventas_pedidos_embalajes)
                    .HasForeignKey(d => d.Pedido)
                    .HasConstraintName("FK_Ventas_pedidos_embalajes_Ventas_pedidos_cabecera");
            });

            modelBuilder.Entity<Ventas_proformas_baja_rentabilidad>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_proformas_baja_rentabilidad");

                entity.ToTable("Ventas_proformas_baja_rentabilidad", "Ventas");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.Property(e => e.Proforma_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Rentabilidad)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Valor_piezas).HasColumnType("money");
            });

            modelBuilder.Entity<Ventas_proformas_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_proformas_cabecera");

                entity.ToTable("Ventas_proformas_cabecera", "Ventas");

                entity.HasIndex(e => e.Aprobado)
                    .HasName("Idx_aprobado");

                entity.HasIndex(e => e.Cliente)
                    .HasName("Idx_Cliente");

                entity.HasIndex(e => e.Ejercicio)
                    .HasName("Idx_ejercicio");

                entity.HasIndex(e => e.Fecha_proforma)
                    .HasName("Idx_FechaProforma");

                entity.HasIndex(e => e.Modo)
                    .HasName("Idx_Modo");

                entity.HasIndex(e => new { e.Ejercicio, e.Modo })
                    .HasName("Idx_EjercicioModo");

                entity.HasIndex(e => new { e.Ejercicio, e.Cliente, e.Pedido })
                    .HasName("EjercicioClientePedido");

                entity.HasIndex(e => new { e.Proforma, e.Ejercicio, e.Modo })
                    .HasName("ProformaEjercicioModo")
                    .IsUnique();

                entity.Property(e => e.Agencia_transporte).HasColumnType("nchar(6)");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("0");

                entity.Property(e => e.Base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_manual_peso_bruto).HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_manual_peso_neto).HasDefaultValueSql("0");

                entity.Property(e => e.Calculo_manual_volumen).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Cliente_empresa).HasMaxLength(50);

                entity.Property(e => e.Decimales_cantidad).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_precios).HasDefaultValueSql("2");

                entity.Property(e => e.Decimales_totales).HasDefaultValueSql("2");

                entity.Property(e => e.Descuento_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_pronto_pago)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Descuento_volumen)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Divisa).HasColumnType("nchar(3)");

                entity.Property(e => e.Divisa_cambio).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_decimales).HasDefaultValueSql("0");

                entity.Property(e => e.Divisa_enteros).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio)
                    .IsRequired()
                    .HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Factor_impresion).HasColumnType("decimal");

                entity.Property(e => e.Fecha_aprobacion).HasColumnType("smalldatetime");

                entity.Property(e => e.Fecha_proforma)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Fecha_validez)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()+(30)");

                entity.Property(e => e.Forma_pago).HasColumnType("nchar(4)");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Incoterm1).HasColumnType("nchar(5)");

                entity.Property(e => e.Incoterm2).HasColumnType("nchar(5)");

                entity.Property(e => e.Internet_bloqueado).HasDefaultValueSql("0");

                entity.Property(e => e.Internet_procesado).HasDefaultValueSql("0");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Modo)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.Nif).HasColumnType("nchar(20)");

                entity.Property(e => e.Observaciones_almacen).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_embalajes).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_generales).HasMaxLength(2000);

                entity.Property(e => e.Observaciones_proforma).HasMaxLength(2000);

                entity.Property(e => e.Pedido_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Pedido_restos_generar).HasDefaultValueSql("0");

                entity.Property(e => e.Plazo_entrega).HasColumnType("nchar(20)");

                entity.Property(e => e.Portes_base_imponible)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuento_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_descuentos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Portes_iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_observaciones).HasMaxLength(2000);

                entity.Property(e => e.Portes_re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_porcentaje)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_recargos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Portes_tipo).HasDefaultValueSql("0");

                entity.Property(e => e.Prioridad).HasDefaultValueSql("3");

                entity.Property(e => e.Proforma)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Recargo_factura)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_financiero)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_total1)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Recargo_total2)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Referencia).HasMaxLength(20);

                entity.Property(e => e.Retencion)
                    .HasColumnType("smallmoney")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Serie).HasColumnType("nchar(1)");

                entity.Property(e => e.Subtotal)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_pronto_pago)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_descuento_volumen)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_divisa_base)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalajes_suplementos)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_general)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_portes)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_equivalencia)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_factura)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_recargo_financiero)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_retencion)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_unidades).HasDefaultValueSql("0");

                entity.Property(e => e.Total_volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.Agencia_transporteNavigation)
                    .WithMany(p => p.Ventas_proformas_cabecera)
                    .HasForeignKey(d => d.Agencia_transporte)
                    .HasConstraintName("FK_Ventas_proformas_cabecera_Agencias_transporte");

                entity.HasOne(d => d.AgenteNavigation)
                    .WithMany(p => p.Ventas_proformas_cabecera)
                    .HasForeignKey(d => d.Agente)
                    .HasConstraintName("FK_Ventas_proformas_cabecera_Agentes");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Ventas_proformas_cabecera)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Ventas_proformas_cabecera_Clientes");

                entity.HasOne(d => d.Forma_pagoNavigation)
                    .WithMany(p => p.Ventas_proformas_cabecera)
                    .HasForeignKey(d => d.Forma_pago)
                    .HasConstraintName("FK_Ventas_proformas_cabecera_Formas_pago");
            });

            modelBuilder.Entity<Ventas_proformas_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Clientes_proformas_detalle");

                entity.ToTable("Ventas_proformas_detalle", "Ventas");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Centro_coste).HasColumnType("nchar(2)");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Etiqueta).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva).HasColumnType("nchar(3)");

                entity.Property(e => e.Iva_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Minimo_precio_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Orden_trabajo).HasMaxLength(20);

                entity.Property(e => e.Peso_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Peso_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_costo)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio_etiqueta)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Re_porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Tipo_precio).HasDefaultValueSql("0");

                entity.Property(e => e.Total_embalaje)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_iva)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_linea)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total_re)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_bruto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen_neto)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Ventas_proformas_detalle)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Ventas_proformas_detalle_Almacen");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Ventas_proformas_detalle)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Proformas_detalle_Articulos");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Ventas_proformas_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proformas_detalle_Proformas_cabecera");

                entity.HasOne(d => d.EtiquetaNavigation)
                    .WithMany(p => p.Ventas_proformas_detalle)
                    .HasForeignKey(d => d.Etiqueta)
                    .HasConstraintName("FK_Proformas_detalle_Embalajes");
            });

            modelBuilder.Entity<Ventas_proformas_embalajes>(entity =>
            {
                entity.HasKey(e => new { e.Proforma, e.Embalaje })
                    .HasName("PK_Proformas_embalajes");

                entity.ToTable("Ventas_proformas_embalajes", "Ventas");

                entity.Property(e => e.Embalaje).HasColumnType("nchar(3)");

                entity.Property(e => e.Calculo).HasDefaultValueSql("0");

                entity.Property(e => e.Cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Peso)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("numeric")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Precio).HasColumnType("money");

                entity.Property(e => e.Total)
                    .HasColumnType("money")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Volumen)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.EmbalajeNavigation)
                    .WithMany(p => p.Ventas_proformas_embalajes)
                    .HasForeignKey(d => d.Embalaje)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Ventas_proformas_embalajes_Embalajes");

                entity.HasOne(d => d.ProformaNavigation)
                    .WithMany(p => p.Ventas_proformas_embalajes)
                    .HasForeignKey(d => d.Proforma)
                    .HasConstraintName("FK_Ventas_proformas_embalajes_Ventas_proformas_cabecera");
            });

            modelBuilder.Entity<Ventas_proformas_totales>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_proformas_totales");

                entity.ToTable("Ventas_proformas_totales", "Ventas");

                entity.Property(e => e.Porcentaje)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Ventas_reclamaciones_cabecera>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Ventas_reclamaciones_cabecera");

                entity.ToTable("Ventas_reclamaciones_cabecera", "Ventas");

                entity.HasIndex(e => e.Cliente)
                    .HasName("Idx_interlocutor");

                entity.Property(e => e.Abono).HasDefaultValueSql("0");

                entity.Property(e => e.Abono_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Abono_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Agente).HasColumnType("nchar(6)");

                entity.Property(e => e.Aprobado).HasDefaultValueSql("0");

                entity.Property(e => e.Cliente).HasColumnType("nchar(6)");

                entity.Property(e => e.Cliente_empresa).HasMaxLength(50);

                entity.Property(e => e.Confirmar).HasDefaultValueSql("0");

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Empresa).HasColumnType("nchar(3)");

                entity.Property(e => e.Enviada).HasDefaultValueSql("0");

                entity.Property(e => e.Fecha_reclamacion)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Idioma).HasColumnType("nchar(10)");

                entity.Property(e => e.Internet_procesado).HasDefaultValueSql("0");

                entity.Property(e => e.Modo).HasColumnType("nchar(1)");

                entity.Property(e => e.Reclamacion).HasColumnType("nchar(6)");

                entity.Property(e => e.Referencia).HasColumnType("nchar(20)");

                entity.Property(e => e.Responsable1).HasColumnType("nchar(5)");

                entity.Property(e => e.Responsable2).HasColumnType("nchar(5)");

                entity.Property(e => e.Serie)
                    .HasColumnType("nchar(1)")
                    .HasDefaultValueSql("N'A'");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.AgenteNavigation)
                    .WithMany(p => p.Ventas_reclamaciones_cabecera)
                    .HasForeignKey(d => d.Agente)
                    .HasConstraintName("FK_Ventas_reclamaciones_cabecera_Agentes");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Ventas_reclamaciones_cabecera)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_Ventas_reclamaciones_cabecera_Clientes");
            });

            modelBuilder.Entity<Ventas_reclamaciones_detalle>(entity =>
            {
                entity.HasKey(e => e.Numero)
                    .HasName("PK_Ventas_reclamaciones_detalle");

                entity.ToTable("Ventas_reclamaciones_detalle", "Ventas");

                entity.HasIndex(e => e.Articulo)
                    .HasName("Idx_articulo");

                entity.HasIndex(e => e.Bloqueada)
                    .HasName("Idx_bloqueada");

                entity.HasIndex(e => e.Codigo)
                    .HasName("Idx_codigo");

                entity.HasIndex(e => e.Factura)
                    .HasName("Idx_factura");

                entity.Property(e => e.Albaran_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Albaran_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Albaran_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Almacen).HasColumnType("nchar(3)");

                entity.Property(e => e.Articulo).HasColumnType("nchar(20)");

                entity.Property(e => e.Bloqueada).HasDefaultValueSql("0");

                entity.Property(e => e.Descripcion).HasMaxLength(200);

                entity.Property(e => e.Ejercicio).HasColumnType("nchar(4)");

                entity.Property(e => e.Factura_cantidad).HasDefaultValueSql("0");

                entity.Property(e => e.Factura_codigo).HasColumnType("nchar(6)");

                entity.Property(e => e.Factura_fecha).HasColumnType("smalldatetime");

                entity.Property(e => e.Forzar_abono).HasDefaultValueSql("0");

                entity.Property(e => e.Incidencias).HasMaxLength(2000);

                entity.Property(e => e.Motivo)
                    .HasColumnType("nchar(20)")
                    .HasDefaultValueSql("N'Golpes'");

                entity.Property(e => e.Sinonimo).HasColumnType("nchar(20)");

                entity.Property(e => e.Stocks).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_abolladas).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_abonadas).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_chatarra).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_perfectas).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_pintadas).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_recibidas).HasDefaultValueSql("0");

                entity.Property(e => e.Unidades_reclamadas).HasDefaultValueSql("0");

                entity.HasOne(d => d.AlmacenNavigation)
                    .WithMany(p => p.Ventas_reclamaciones_detalle)
                    .HasForeignKey(d => d.Almacen)
                    .HasConstraintName("FK_Ventas_reclamaciones_detalle_Almacen");

                entity.HasOne(d => d.ArticuloNavigation)
                    .WithMany(p => p.Ventas_reclamaciones_detalle)
                    .HasForeignKey(d => d.Articulo)
                    .HasConstraintName("FK_Ventas_reclamaciones_detalle_Articulos");

                entity.HasOne(d => d.CodigoNavigation)
                    .WithMany(p => p.Ventas_reclamaciones_detalle)
                    .HasForeignKey(d => d.Codigo)
                    .HasConstraintName("FK_Ventas_reclamaciones_detalle_Ventas_reclamaciones_cabecera");

                entity.HasOne(d => d.FacturaNavigation)
                    .WithMany(p => p.Ventas_reclamaciones_detalle)
                    .HasForeignKey(d => d.Factura)
                    .HasConstraintName("FK_Reclamaciones_detalle_Facturas_cabecera");
            });

            modelBuilder.Entity<Vinculos_externos>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_CondicionesBancarias");

                entity.ToTable("Vinculos_externos", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(5)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(50);

                entity.Property(e => e.Menu).HasMaxLength(100);

                entity.Property(e => e.Tipo_documento).HasMaxLength(30);
            });

            modelBuilder.Entity<Vinculos_externos_usuarios>(entity =>
            {
                entity.HasKey(e => new { e.Vinculo, e.Usuario })
                    .HasName("PK_Vinculos_externos_usuarios");

                entity.ToTable("Vinculos_externos_usuarios", "General");

                entity.Property(e => e.Vinculo).HasColumnType("nchar(5)");

                entity.Property(e => e.Usuario).HasColumnType("nchar(5)");

                entity.HasOne(d => d.VinculoNavigation)
                    .WithMany(p => p.Vinculos_externos_usuarios)
                    .HasForeignKey(d => d.Vinculo)
                    .HasConstraintName("FK_Vinculos_externos_usuarios_Vinculos_externos");
            });

            modelBuilder.Entity<Zona_seccion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Centros_trabajo");

                entity.ToTable("Zona_seccion", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasMaxLength(150);

                entity.Property(e => e.Zona).HasColumnType("nchar(2)");

                entity.HasOne(d => d.ZonaNavigation)
                    .WithMany(p => p.Zona_seccion)
                    .HasForeignKey(d => d.Zona)
                    .HasConstraintName("FK_Zona_seccion_Zonas_trabajo");
            });

            modelBuilder.Entity<Zonas_centros>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Zonas_centros");

                entity.ToTable("Zonas_centros", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(4)");

                entity.Property(e => e.Descripcion).HasColumnType("nchar(30)");

                entity.Property(e => e.Observaciones).HasColumnType("text");

                entity.Property(e => e.Seccion).HasColumnType("nchar(2)");

                entity.HasOne(d => d.SeccionNavigation)
                    .WithMany(p => p.Zonas_centros)
                    .HasForeignKey(d => d.Seccion)
                    .HasConstraintName("FK_Zonas_centros_Zona_seccion");
            });

            modelBuilder.Entity<Zonas_centros_secciones>(entity =>
            {
                entity.HasKey(e => new { e.Centros, e.Empresas_secciones })
                    .HasName("PK_Zonas_centros_secciones");

                entity.ToTable("Zonas_centros_secciones", "General");

                entity.Property(e => e.Centros).HasColumnType("char(4)");

                entity.Property(e => e.Empresas_secciones).HasColumnType("char(5)");
            });

            modelBuilder.Entity<Zonas_secciones_empresa>(entity =>
            {
                entity.HasKey(e => new { e.Centros, e.Secciones })
                    .HasName("PK_Zonas_centros_sec");

                entity.ToTable("Zonas_secciones_empresa", "General");

                entity.Property(e => e.Centros).HasColumnType("char(4)");

                entity.Property(e => e.Secciones).HasColumnType("char(5)");
            });

            modelBuilder.Entity<Zonas_trabajo>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_Zonas_trabajo");

                entity.ToTable("Zonas_trabajo", "General");

                entity.Property(e => e.Codigo).HasColumnType("nchar(2)");

                entity.Property(e => e.Codaux).ValueGeneratedOnAdd();

                entity.Property(e => e.Descripcion).HasColumnType("varchar(150)");

                entity.Property(e => e.Observaciones).HasColumnType("text");
            });

            modelBuilder.Entity<Zonas_trabajo_edificios>(entity =>
            {
                entity.HasKey(e => new { e.Edificio, e.Zonas_trabajo })
                    .HasName("PK_Zonas_trabajo_edificios");

                entity.ToTable("Zonas_trabajo_edificios", "General");

                entity.Property(e => e.Edificio).HasColumnType("char(1)");

                entity.Property(e => e.Zonas_trabajo).HasColumnType("char(2)");
            });

            modelBuilder.Entity<sysdiagrams>(entity =>
            {
                entity.HasKey(e => e.diagram_id)
                    .HasName("PK__sysdiagrams__42E1EEFE");

                entity.HasIndex(e => new { e.principal_id, e.name })
                    .HasName("UK_principal_name")
                    .IsUnique();

                entity.Property(e => e.name)
                    .IsRequired()
                    .HasColumnType("sysname");
            });
        }

        public virtual DbSet<Agencias_transporte> Agencias_transporte { get; set; }
        public virtual DbSet<Agencias_transporte_costes_envios> Agencias_transporte_costes_envios { get; set; }
        public virtual DbSet<Agencias_transporte_costes_trayectos> Agencias_transporte_costes_trayectos { get; set; }
        public virtual DbSet<Agencias_transporte_departamentos> Agencias_transporte_departamentos { get; set; }
        public virtual DbSet<Agencias_transporte_etiquetas_temporal> Agencias_transporte_etiquetas_temporal { get; set; }
        public virtual DbSet<Agencias_transporte_matriculas> Agencias_transporte_matriculas { get; set; }
        public virtual DbSet<Agencias_transporte_tarifas> Agencias_transporte_tarifas { get; set; }
        public virtual DbSet<Agencias_transporte_tipos_portes> Agencias_transporte_tipos_portes { get; set; }
        public virtual DbSet<Agencias_transporte_visitas> Agencias_transporte_visitas { get; set; }
        public virtual DbSet<Agencias_transporte_zonas> Agencias_transporte_zonas { get; set; }
        public virtual DbSet<Agentes> Agentes { get; set; }
        public virtual DbSet<Agentes_aduanas> Agentes_aduanas { get; set; }
        public virtual DbSet<Agentes_departamentos> Agentes_departamentos { get; set; }
        public virtual DbSet<Agentes_direcciones> Agentes_direcciones { get; set; }
        public virtual DbSet<Agentes_graficos> Agentes_graficos { get; set; }
        public virtual DbSet<Agentes_visitas> Agentes_visitas { get; set; }
        public virtual DbSet<Almacen> Almacen { get; set; }
        public virtual DbSet<Almacen_cadena_suministro> Almacen_cadena_suministro { get; set; }
        public virtual DbSet<Almacen_cadena_suministro_configuracion> Almacen_cadena_suministro_configuracion { get; set; }
        public virtual DbSet<Almacen_inventario> Almacen_inventario { get; set; }
        public virtual DbSet<Almacen_ubicaciones> Almacen_ubicaciones { get; set; }
        public virtual DbSet<Almacenes_departamentos> Almacenes_departamentos { get; set; }
        public virtual DbSet<Anticipos> Anticipos { get; set; }
        public virtual DbSet<Areas_financieras> Areas_financieras { get; set; }
        public virtual DbSet<Articulos> Articulos { get; set; }
        public virtual DbSet<Articulos_acabados> Articulos_acabados { get; set; }
        public virtual DbSet<Articulos_almacen_ubicacion_predeterminada> Articulos_almacen_ubicacion_predeterminada { get; set; }
        public virtual DbSet<Articulos_calculo_punto_pedido> Articulos_calculo_punto_pedido { get; set; }
        public virtual DbSet<Articulos_catalogo_repetidos> Articulos_catalogo_repetidos { get; set; }
        public virtual DbSet<Articulos_centro_coste_porcentaje> Articulos_centro_coste_porcentaje { get; set; }
        public virtual DbSet<Articulos_certificaciones> Articulos_certificaciones { get; set; }
        public virtual DbSet<Articulos_chapa_acabado> Articulos_chapa_acabado { get; set; }
        public virtual DbSet<Articulos_chapa_aspecto> Articulos_chapa_aspecto { get; set; }
        public virtual DbSet<Articulos_chapa_calidad> Articulos_chapa_calidad { get; set; }
        public virtual DbSet<Articulos_chapa_embuticion> Articulos_chapa_embuticion { get; set; }
        public virtual DbSet<Articulos_chapa_forma> Articulos_chapa_forma { get; set; }
        public virtual DbSet<Articulos_chapa_medida> Articulos_chapa_medida { get; set; }
        public virtual DbSet<Articulos_chapa_recubrimiento> Articulos_chapa_recubrimiento { get; set; }
        public virtual DbSet<Articulos_chapa_tratamiento> Articulos_chapa_tratamiento { get; set; }
        public virtual DbSet<Articulos_clasificacion> Articulos_clasificacion { get; set; }
        public virtual DbSet<Articulos_clasificacion_relacion> Articulos_clasificacion_relacion { get; set; }
        public virtual DbSet<Articulos_compatibles> Articulos_compatibles { get; set; }
        public virtual DbSet<Articulos_competidores_acuerdos> Articulos_competidores_acuerdos { get; set; }
        public virtual DbSet<Articulos_conjuntos> Articulos_conjuntos { get; set; }
        public virtual DbSet<Articulos_consumos> Articulos_consumos { get; set; }
        public virtual DbSet<Articulos_contenedores_capacidad> Articulos_contenedores_capacidad { get; set; }
        public virtual DbSet<Articulos_embalajes> Articulos_embalajes { get; set; }
        public virtual DbSet<Articulos_embo_uk> Articulos_embo_uk { get; set; }
        public virtual DbSet<Articulos_estados> Articulos_estados { get; set; }
        public virtual DbSet<Articulos_estados_fabricacion> Articulos_estados_fabricacion { get; set; }
        public virtual DbSet<Articulos_etiquetas_idiomas> Articulos_etiquetas_idiomas { get; set; }
        public virtual DbSet<Articulos_familias_compras> Articulos_familias_compras { get; set; }
        public virtual DbSet<Articulos_familias_medio_ambiente> Articulos_familias_medio_ambiente { get; set; }
        public virtual DbSet<Articulos_familias_ventas> Articulos_familias_ventas { get; set; }
        public virtual DbSet<Articulos_familias_ventas_idiomas> Articulos_familias_ventas_idiomas { get; set; }
        public virtual DbSet<Articulos_familias_ventas_multiples> Articulos_familias_ventas_multiples { get; set; }
        public virtual DbSet<Articulos_familias_ventas_multiples_idiomas> Articulos_familias_ventas_multiples_idiomas { get; set; }
        public virtual DbSet<Articulos_fases> Articulos_fases { get; set; }
        public virtual DbSet<Articulos_formatos_tipo> Articulos_formatos_tipo { get; set; }
        public virtual DbSet<Articulos_graficos> Articulos_graficos { get; set; }
        public virtual DbSet<Articulos_guia_tasaciones> Articulos_guia_tasaciones { get; set; }
        public virtual DbSet<Articulos_idiomas> Articulos_idiomas { get; set; }
        public virtual DbSet<Articulos_imagenes> Articulos_imagenes { get; set; }
        public virtual DbSet<Articulos_lote_fabricacion> Articulos_lote_fabricacion { get; set; }
        public virtual DbSet<Articulos_lotes> Articulos_lotes { get; set; }
        public virtual DbSet<Articulos_lotes_tipos> Articulos_lotes_tipos { get; set; }
        public virtual DbSet<Articulos_medidas> Articulos_medidas { get; set; }
        public virtual DbSet<Articulos_montajes> Articulos_montajes { get; set; }
        public virtual DbSet<Articulos_movimientos> Articulos_movimientos { get; set; }
        public virtual DbSet<Articulos_movimientos_documentos_tipos> Articulos_movimientos_documentos_tipos { get; set; }
        public virtual DbSet<Articulos_movimientos_historico> Articulos_movimientos_historico { get; set; }
        public virtual DbSet<Articulos_movimientos_tipos> Articulos_movimientos_tipos { get; set; }
        public virtual DbSet<Articulos_objetivos> Articulos_objetivos { get; set; }
        public virtual DbSet<Articulos_piecerio_subcontratado> Articulos_piecerio_subcontratado { get; set; }
        public virtual DbSet<Articulos_piezas_tipos> Articulos_piezas_tipos { get; set; }
        public virtual DbSet<Articulos_recursos> Articulos_recursos { get; set; }
        public virtual DbSet<Articulos_referencias> Articulos_referencias { get; set; }
        public virtual DbSet<Articulos_referencias_produccion> Articulos_referencias_produccion { get; set; }
        public virtual DbSet<Articulos_reparto_costes> Articulos_reparto_costes { get; set; }
        public virtual DbSet<Articulos_stocks> Articulos_stocks { get; set; }
        public virtual DbSet<Articulos_stocks_auditacion> Articulos_stocks_auditacion { get; set; }
        public virtual DbSet<Articulos_stocks_auditacion_configuracion> Articulos_stocks_auditacion_configuracion { get; set; }
        public virtual DbSet<Articulos_stocks_configuracion> Articulos_stocks_configuracion { get; set; }
        public virtual DbSet<Articulos_stocks_conjuntos> Articulos_stocks_conjuntos { get; set; }
        public virtual DbSet<Articulos_tarifas> Articulos_tarifas { get; set; }
        public virtual DbSet<Articulos_tarifas_copia> Articulos_tarifas_copia { get; set; }
        public virtual DbSet<Articulos_tarifas_historico> Articulos_tarifas_historico { get; set; }
        public virtual DbSet<Articulos_tarifas_temporal> Articulos_tarifas_temporal { get; set; }
        public virtual DbSet<Articulos_tarifas_tipos> Articulos_tarifas_tipos { get; set; }
        public virtual DbSet<Articulos_tipos_calidad> Articulos_tipos_calidad { get; set; }
        public virtual DbSet<Articulos_tipos_competencia> Articulos_tipos_competencia { get; set; }
        public virtual DbSet<Articulos_tipos_materia_prima> Articulos_tipos_materia_prima { get; set; }
        public virtual DbSet<Articulos_tipos_origen> Articulos_tipos_origen { get; set; }
        public virtual DbSet<Articulos_tipos_produccion> Articulos_tipos_produccion { get; set; }
        public virtual DbSet<Articulos_tipos_productos> Articulos_tipos_productos { get; set; }
        public virtual DbSet<Articulos_tipos_suministro> Articulos_tipos_suministro { get; set; }
        public virtual DbSet<Articulos_tipos_troquel> Articulos_tipos_troquel { get; set; }
        public virtual DbSet<Articulos_traducciones> Articulos_traducciones { get; set; }
        public virtual DbSet<Articulos_troqueles_costo_compra> Articulos_troqueles_costo_compra { get; set; }
        public virtual DbSet<Articulos_utiles> Articulos_utiles { get; set; }
        public virtual DbSet<Bancos> Bancos { get; set; }
        public virtual DbSet<Bancos_cuentas> Bancos_cuentas { get; set; }
        public virtual DbSet<Bancos_cuentas_conceptos> Bancos_cuentas_conceptos { get; set; }
        public virtual DbSet<Bancos_cuentas_configuracion> Bancos_cuentas_configuracion { get; set; }
        public virtual DbSet<Bancos_cuentas_divisas_apuntes> Bancos_cuentas_divisas_apuntes { get; set; }
        public virtual DbSet<Bancos_cuentas_divisas_tipos> Bancos_cuentas_divisas_tipos { get; set; }
        public virtual DbSet<Bancos_cuentas_tipos> Bancos_cuentas_tipos { get; set; }
        public virtual DbSet<Calendarios> Calendarios { get; set; }
        public virtual DbSet<Calendarios_configuracion> Calendarios_configuracion { get; set; }
        public virtual DbSet<Calendarios_tipos> Calendarios_tipos { get; set; }
        public virtual DbSet<Cargas_tipos> Cargas_tipos { get; set; }
        public virtual DbSet<Cartera_compras> Cartera_compras { get; set; }
        public virtual DbSet<Cartera_compras_historico> Cartera_compras_historico { get; set; }
        public virtual DbSet<Cartera_configuracion> Cartera_configuracion { get; set; }
        public virtual DbSet<Cartera_estados> Cartera_estados { get; set; }
        public virtual DbSet<Cartera_ventas> Cartera_ventas { get; set; }
        public virtual DbSet<Cartera_ventas_historico> Cartera_ventas_historico { get; set; }
        public virtual DbSet<Centros_coste_financieros> Centros_coste_financieros { get; set; }
        public virtual DbSet<Centros_costes> Centros_costes { get; set; }
        public virtual DbSet<Centros_costes_grupos> Centros_costes_grupos { get; set; }
        public virtual DbSet<Centros_costes_grupos_relacion> Centros_costes_grupos_relacion { get; set; }
        public virtual DbSet<Centros_costes_maquinas> Centros_costes_maquinas { get; set; }
        public virtual DbSet<Centros_trabajo> Centros_trabajo { get; set; }
        public virtual DbSet<Centros_trabajo_grupos> Centros_trabajo_grupos { get; set; }
        public virtual DbSet<Centros_trabajo_grupos_relacion> Centros_trabajo_grupos_relacion { get; set; }
        public virtual DbSet<Centros_trabajo_tipos> Centros_trabajo_tipos { get; set; }
        public virtual DbSet<Certificaciones_producto> Certificaciones_producto { get; set; }
        public virtual DbSet<Certificaciones_sistema> Certificaciones_sistema { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Clientes_anticipos> Clientes_anticipos { get; set; }
        public virtual DbSet<Clientes_articulos_bloqueados> Clientes_articulos_bloqueados { get; set; }
        public virtual DbSet<Clientes_articulos_certificados> Clientes_articulos_certificados { get; set; }
        public virtual DbSet<Clientes_bancos> Clientes_bancos { get; set; }
        public virtual DbSet<Clientes_cuentas_contables> Clientes_cuentas_contables { get; set; }
        public virtual DbSet<Clientes_departamentos> Clientes_departamentos { get; set; }
        public virtual DbSet<Clientes_direcciones> Clientes_direcciones { get; set; }
        public virtual DbSet<Clientes_direcciones_tipos> Clientes_direcciones_tipos { get; set; }
        public virtual DbSet<Clientes_embalajes_configuracion> Clientes_embalajes_configuracion { get; set; }
        public virtual DbSet<Clientes_graficos> Clientes_graficos { get; set; }
        public virtual DbSet<Clientes_grupos_compras> Clientes_grupos_compras { get; set; }
        public virtual DbSet<Clientes_grupos_compras_rappels> Clientes_grupos_compras_rappels { get; set; }
        public virtual DbSet<Clientes_grupos_tarifas> Clientes_grupos_tarifas { get; set; }
        public virtual DbSet<Clientes_grupos_tarifas_copia> Clientes_grupos_tarifas_copia { get; set; }
        public virtual DbSet<Clientes_grupos_tarifas_historico> Clientes_grupos_tarifas_historico { get; set; }
        public virtual DbSet<Clientes_grupos_tarifas_temporal> Clientes_grupos_tarifas_temporal { get; set; }
        public virtual DbSet<Clientes_grupos_tarifas_tipos> Clientes_grupos_tarifas_tipos { get; set; }
        public virtual DbSet<Clientes_internet_accesos> Clientes_internet_accesos { get; set; }
        public virtual DbSet<Clientes_internet_grupos> Clientes_internet_grupos { get; set; }
        public virtual DbSet<Clientes_internet_seguridad> Clientes_internet_seguridad { get; set; }
        public virtual DbSet<Clientes_internet_seguridad_claves> Clientes_internet_seguridad_claves { get; set; }
        public virtual DbSet<Clientes_objetivos> Clientes_objetivos { get; set; }
        public virtual DbSet<Clientes_precios_especiales> Clientes_precios_especiales { get; set; }
        public virtual DbSet<Clientes_precios_especiales_cantidad> Clientes_precios_especiales_cantidad { get; set; }
        public virtual DbSet<Clientes_precios_especiales_cantidad_copia> Clientes_precios_especiales_cantidad_copia { get; set; }
        public virtual DbSet<Clientes_precios_especiales_cantidad_historico> Clientes_precios_especiales_cantidad_historico { get; set; }
        public virtual DbSet<Clientes_precios_especiales_cantidad_temporal> Clientes_precios_especiales_cantidad_temporal { get; set; }
        public virtual DbSet<Clientes_precios_especiales_copia> Clientes_precios_especiales_copia { get; set; }
        public virtual DbSet<Clientes_precios_especiales_historico> Clientes_precios_especiales_historico { get; set; }
        public virtual DbSet<Clientes_precios_especiales_temporal> Clientes_precios_especiales_temporal { get; set; }
        public virtual DbSet<Clientes_precios_procesos> Clientes_precios_procesos { get; set; }
        public virtual DbSet<Clientes_precios_tipos> Clientes_precios_tipos { get; set; }
        public virtual DbSet<Clientes_procesos> Clientes_procesos { get; set; }
        public virtual DbSet<Clientes_rappels> Clientes_rappels { get; set; }
        public virtual DbSet<Clientes_riesgos> Clientes_riesgos { get; set; }
        public virtual DbSet<Clientes_riesgos_informacion> Clientes_riesgos_informacion { get; set; }
        public virtual DbSet<Clientes_sinonimos> Clientes_sinonimos { get; set; }
        public virtual DbSet<Clientes_sugerencias> Clientes_sugerencias { get; set; }
        public virtual DbSet<Clientes_transporte_expediciones> Clientes_transporte_expediciones { get; set; }
        public virtual DbSet<Clientes_valoracion> Clientes_valoracion { get; set; }
        public virtual DbSet<Clientes_visitas> Clientes_visitas { get; set; }
        public virtual DbSet<Clientes_zonas> Clientes_zonas { get; set; }
        public virtual DbSet<Codificacion_defectos> Codificacion_defectos { get; set; }
        public virtual DbSet<Colores_ral> Colores_ral { get; set; }
        public virtual DbSet<Competidores> Competidores { get; set; }
        public virtual DbSet<Competidores_articulos_certificados> Competidores_articulos_certificados { get; set; }
        public virtual DbSet<Competidores_departamentos> Competidores_departamentos { get; set; }
        public virtual DbSet<Competidores_ofertas> Competidores_ofertas { get; set; }
        public virtual DbSet<Competidores_sinonimos> Competidores_sinonimos { get; set; }
        public virtual DbSet<Competidores_visitas> Competidores_visitas { get; set; }
        public virtual DbSet<Componentes> Componentes { get; set; }
        public virtual DbSet<Compras_albaranes_cabecera> Compras_albaranes_cabecera { get; set; }
        public virtual DbSet<Compras_albaranes_detalle> Compras_albaranes_detalle { get; set; }
        public virtual DbSet<Compras_albaranes_entradas> Compras_albaranes_entradas { get; set; }
        public virtual DbSet<Compras_albaranes_entradas_log> Compras_albaranes_entradas_log { get; set; }
        public virtual DbSet<Compras_facturas_cabecera> Compras_facturas_cabecera { get; set; }
        public virtual DbSet<Compras_facturas_detalle> Compras_facturas_detalle { get; set; }
        public virtual DbSet<Compras_facturas_detalle_cuentas> Compras_facturas_detalle_cuentas { get; set; }
        public virtual DbSet<Compras_facturas_periodos_cierre> Compras_facturas_periodos_cierre { get; set; }
        public virtual DbSet<Compras_pedidos_cabecera> Compras_pedidos_cabecera { get; set; }
        public virtual DbSet<Compras_pedidos_detalle> Compras_pedidos_detalle { get; set; }
        public virtual DbSet<Compras_prestamo_material> Compras_prestamo_material { get; set; }
        public virtual DbSet<Compras_proformas_cabecera> Compras_proformas_cabecera { get; set; }
        public virtual DbSet<Compras_proformas_detalle> Compras_proformas_detalle { get; set; }
        public virtual DbSet<Compras_proveedores_articulos_presupuestados> Compras_proveedores_articulos_presupuestados { get; set; }
        public virtual DbSet<Compras_reclamaciones_cabecera> Compras_reclamaciones_cabecera { get; set; }
        public virtual DbSet<Compras_reclamaciones_detalle> Compras_reclamaciones_detalle { get; set; }
        public virtual DbSet<Contenedores_tipos> Contenedores_tipos { get; set; }
        public virtual DbSet<Controles_requeridos> Controles_requeridos { get; set; }
        public virtual DbSet<Costes_articulos_configuracion> Costes_articulos_configuracion { get; set; }
        public virtual DbSet<Costes_configuracion> Costes_configuracion { get; set; }
        public virtual DbSet<Costes_configuracion_tipos> Costes_configuracion_tipos { get; set; }
        public virtual DbSet<Cuentas_contables_tipos> Cuentas_contables_tipos { get; set; }
        public virtual DbSet<Departamentos_tipos> Departamentos_tipos { get; set; }
        public virtual DbSet<Direcciones_mails_direcciones> Direcciones_mails_direcciones { get; set; }
        public virtual DbSet<Direcciones_tipos> Direcciones_tipos { get; set; }
        public virtual DbSet<Documentacion> Documentacion { get; set; }
        public virtual DbSet<Documentacion_archivos> Documentacion_archivos { get; set; }
        public virtual DbSet<Documentacion_conceptos> Documentacion_conceptos { get; set; }
        public virtual DbSet<Documentacion_configuracion> Documentacion_configuracion { get; set; }
        public virtual DbSet<Documentacion_grupos> Documentacion_grupos { get; set; }
        public virtual DbSet<Embalajes> Embalajes { get; set; }
        public virtual DbSet<Embalajes_cajas_tipos> Embalajes_cajas_tipos { get; set; }
        public virtual DbSet<Embalajes_idiomas> Embalajes_idiomas { get; set; }
        public virtual DbSet<Embalajes_tipos> Embalajes_tipos { get; set; }
        public virtual DbSet<Empresa_activa> Empresa_activa { get; set; }
        public virtual DbSet<Errores_sistema> Errores_sistema { get; set; }
        public virtual DbSet<Estadistica_ventas_coches_europa> Estadistica_ventas_coches_europa { get; set; }
        public virtual DbSet<Estadisticas> Estadisticas { get; set; }
        public virtual DbSet<Estadisticas_listas> Estadisticas_listas { get; set; }
        public virtual DbSet<Estadisticas_usuarios> Estadisticas_usuarios { get; set; }
        public virtual DbSet<Etiquetas> Etiquetas { get; set; }
        public virtual DbSet<Etiquetas_rangos> Etiquetas_rangos { get; set; }
        public virtual DbSet<Etiquetas_registro> Etiquetas_registro { get; set; }
        public virtual DbSet<Evaluacion_clientes> Evaluacion_clientes { get; set; }
        public virtual DbSet<Evaluacion_proveedor> Evaluacion_proveedor { get; set; }
        public virtual DbSet<Evaluacion_proveedor_servicios> Evaluacion_proveedor_servicios { get; set; }
        public virtual DbSet<Evaluacion_transportistas> Evaluacion_transportistas { get; set; }
        public virtual DbSet<Evolucion_costes_lotes_totales> Evolucion_costes_lotes_totales { get; set; }
        public virtual DbSet<Fabricantes> Fabricantes { get; set; }
        public virtual DbSet<Fases> Fases { get; set; }
        public virtual DbSet<Fases_tipos> Fases_tipos { get; set; }
        public virtual DbSet<Formacion_biblioteca_cursos> Formacion_biblioteca_cursos { get; set; }
        public virtual DbSet<Formacion_cursos> Formacion_cursos { get; set; }
        public virtual DbSet<Formacion_cursos_descripcion> Formacion_cursos_descripcion { get; set; }
        public virtual DbSet<Formacion_cursos_obligatorios> Formacion_cursos_obligatorios { get; set; }
        public virtual DbSet<Formacion_cursos_personal> Formacion_cursos_personal { get; set; }
        public virtual DbSet<Formacion_ficheros> Formacion_ficheros { get; set; }
        public virtual DbSet<Formacion_plan_cabecera> Formacion_plan_cabecera { get; set; }
        public virtual DbSet<Formacion_plan_detalle> Formacion_plan_detalle { get; set; }
        public virtual DbSet<Formacion_registros> Formacion_registros { get; set; }
        public virtual DbSet<Formacion_tipo_curso> Formacion_tipo_curso { get; set; }
        public virtual DbSet<Formacion_tipo_formacion> Formacion_tipo_formacion { get; set; }
        public virtual DbSet<Formas_pago> Formas_pago { get; set; }
        public virtual DbSet<Formas_pago_idiomas> Formas_pago_idiomas { get; set; }
        public virtual DbSet<Formulas_calculo> Formulas_calculo { get; set; }
        public virtual DbSet<Formulas_calculo_modulos> Formulas_calculo_modulos { get; set; }
        public virtual DbSet<Formulas_campos> Formulas_campos { get; set; }
        public virtual DbSet<Incidencias> Incidencias { get; set; }
        public virtual DbSet<Incidencias_usuarios> Incidencias_usuarios { get; set; }
        public virtual DbSet<Incoterms> Incoterms { get; set; }
        public virtual DbSet<Informes> Informes { get; set; }
        public virtual DbSet<Informes_formatos> Informes_formatos { get; set; }
        public virtual DbSet<Interlocutores> Interlocutores { get; set; }
        public virtual DbSet<Interlocutores_clasificacion> Interlocutores_clasificacion { get; set; }
        public virtual DbSet<Iso_acciones_correctivas> Iso_acciones_correctivas { get; set; }
        public virtual DbSet<Iso_auditorias> Iso_auditorias { get; set; }
        public virtual DbSet<Iso_causas_queja> Iso_causas_queja { get; set; }
        public virtual DbSet<Iso_no_conformidades> Iso_no_conformidades { get; set; }
        public virtual DbSet<Iso_reclamaciones> Iso_reclamaciones { get; set; }
        public virtual DbSet<Ivas> Ivas { get; set; }
        public virtual DbSet<Ivas_categorias> Ivas_categorias { get; set; }
        public virtual DbSet<Jaulas> Jaulas { get; set; }
        public virtual DbSet<Jaulas_movimientos> Jaulas_movimientos { get; set; }
        public virtual DbSet<Jaulas_stocks> Jaulas_stocks { get; set; }
        public virtual DbSet<Lanzamientos> Lanzamientos { get; set; }
        public virtual DbSet<Lanzamientos_reserva> Lanzamientos_reserva { get; set; }
        public virtual DbSet<Lenguajes> Lenguajes { get; set; }
        public virtual DbSet<Lista_materiales> Lista_materiales { get; set; }
        public virtual DbSet<Lista_materiales_historico> Lista_materiales_historico { get; set; }
        public virtual DbSet<Lista_materiales_modificaciones> Lista_materiales_modificaciones { get; set; }
        public virtual DbSet<Lista_materiales_modificaciones_fotos> Lista_materiales_modificaciones_fotos { get; set; }
        public virtual DbSet<Mails_tipos> Mails_tipos { get; set; }
        public virtual DbSet<Mantenimiento_detalles_averias> Mantenimiento_detalles_averias { get; set; }
        public virtual DbSet<Mantenimiento_hojas_trabajo_cabecera> Mantenimiento_hojas_trabajo_cabecera { get; set; }
        public virtual DbSet<Mantenimiento_hojas_trabajo_detalle> Mantenimiento_hojas_trabajo_detalle { get; set; }
        public virtual DbSet<Mantenimiento_lanzamientos_cabecera> Mantenimiento_lanzamientos_cabecera { get; set; }
        public virtual DbSet<Mantenimiento_lanzamientos_detalle> Mantenimiento_lanzamientos_detalle { get; set; }
        public virtual DbSet<Mantenimiento_preventivo_cabecera> Mantenimiento_preventivo_cabecera { get; set; }
        public virtual DbSet<Mantenimiento_preventivo_detalle> Mantenimiento_preventivo_detalle { get; set; }
        public virtual DbSet<Mantenimiento_solicitud_asistencia_tecnica> Mantenimiento_solicitud_asistencia_tecnica { get; set; }
        public virtual DbSet<Mantenimiento_solicitudes> Mantenimiento_solicitudes { get; set; }
        public virtual DbSet<Mantenimiento_tipo_maestro> Mantenimiento_tipo_maestro { get; set; }
        public virtual DbSet<Maquinas> Maquinas { get; set; }
        public virtual DbSet<Maquinas_centros_trabajo_relacion> Maquinas_centros_trabajo_relacion { get; set; }
        public virtual DbSet<Maquinas_componentes> Maquinas_componentes { get; set; }
        public virtual DbSet<Maquinas_familias> Maquinas_familias { get; set; }
        public virtual DbSet<Maquinas_grupos> Maquinas_grupos { get; set; }
        public virtual DbSet<Maquinas_grupos_componentes> Maquinas_grupos_componentes { get; set; }
        public virtual DbSet<Maquinas_grupos_relacion> Maquinas_grupos_relacion { get; set; }
        public virtual DbSet<Maquinas_preventivo_relacion> Maquinas_preventivo_relacion { get; set; }
        public virtual DbSet<Maquinas_tipos> Maquinas_tipos { get; set; }
        public virtual DbSet<Marcas> Marcas { get; set; }
        public virtual DbSet<Materiales> Materiales { get; set; }
        public virtual DbSet<Normas> Normas { get; set; }
        public virtual DbSet<Observaciones_notificaciones> Observaciones_notificaciones { get; set; }
        public virtual DbSet<Operaciones_auxiliares> Operaciones_auxiliares { get; set; }
        public virtual DbSet<Ordenes_trabajo> Ordenes_trabajo { get; set; }
        public virtual DbSet<Ordenes_trabajo_estados> Ordenes_trabajo_estados { get; set; }
        public virtual DbSet<Ordenes_trabajo_tipos> Ordenes_trabajo_tipos { get; set; }
        public virtual DbSet<Personal> Personal { get; set; }
        public virtual DbSet<Personal_absentismo> Personal_absentismo { get; set; }
        public virtual DbSet<Personal_accidentes> Personal_accidentes { get; set; }
        public virtual DbSet<Personal_accidentes_CNAE> Personal_accidentes_CNAE { get; set; }
        public virtual DbSet<Personal_accidentes_CNO> Personal_accidentes_CNO { get; set; }
        public virtual DbSet<Personal_accidentes_actividad_actual> Personal_accidentes_actividad_actual { get; set; }
        public virtual DbSet<Personal_accidentes_cargos> Personal_accidentes_cargos { get; set; }
        public virtual DbSet<Personal_accidentes_causa> Personal_accidentes_causa { get; set; }
        public virtual DbSet<Personal_accidentes_descripcion> Personal_accidentes_descripcion { get; set; }
        public virtual DbSet<Personal_accidentes_grado_lesion> Personal_accidentes_grado_lesion { get; set; }
        public virtual DbSet<Personal_accidentes_lesion> Personal_accidentes_lesion { get; set; }
        public virtual DbSet<Personal_accidentes_localizacion> Personal_accidentes_localizacion { get; set; }
        public virtual DbSet<Personal_accidentes_lugar> Personal_accidentes_lugar { get; set; }
        public virtual DbSet<Personal_accidentes_motivo> Personal_accidentes_motivo { get; set; }
        public virtual DbSet<Personal_accidentes_objetos_implicados> Personal_accidentes_objetos_implicados { get; set; }
        public virtual DbSet<Personal_accidentes_parte> Personal_accidentes_parte { get; set; }
        public virtual DbSet<Personal_accidentes_repeticion> Personal_accidentes_repeticion { get; set; }
        public virtual DbSet<Personal_accidentes_seccion_estadisticas> Personal_accidentes_seccion_estadisticas { get; set; }
        public virtual DbSet<Personal_accidentes_secciones> Personal_accidentes_secciones { get; set; }
        public virtual DbSet<Personal_accidentes_situacion_profesional> Personal_accidentes_situacion_profesional { get; set; }
        public virtual DbSet<Personal_accidentes_tipo_asistencia> Personal_accidentes_tipo_asistencia { get; set; }
        public virtual DbSet<Personal_accidentes_tipo_trabajo> Personal_accidentes_tipo_trabajo { get; set; }
        public virtual DbSet<Personal_almacenes_vestuarios> Personal_almacenes_vestuarios { get; set; }
        public virtual DbSet<Personal_calendarios> Personal_calendarios { get; set; }
        public virtual DbSet<Personal_calendarios_base> Personal_calendarios_base { get; set; }
        public virtual DbSet<Personal_calendarios_base_detalle> Personal_calendarios_base_detalle { get; set; }
        public virtual DbSet<Personal_calendarios_tipo> Personal_calendarios_tipo { get; set; }
        public virtual DbSet<Personal_cargos_empresa> Personal_cargos_empresa { get; set; }
        public virtual DbSet<Personal_categorias> Personal_categorias { get; set; }
        public virtual DbSet<Personal_categorias_historico> Personal_categorias_historico { get; set; }
        public virtual DbSet<Personal_contratos_oficiales> Personal_contratos_oficiales { get; set; }
        public virtual DbSet<Personal_contratos_oficiales_bonificaciones> Personal_contratos_oficiales_bonificaciones { get; set; }
        public virtual DbSet<Personal_curriculum_vitae> Personal_curriculum_vitae { get; set; }
        public virtual DbSet<Personal_departamentos> Personal_departamentos { get; set; }
        public virtual DbSet<Personal_empresas> Personal_empresas { get; set; }
        public virtual DbSet<Personal_empresas_historico> Personal_empresas_historico { get; set; }
        public virtual DbSet<Personal_equipamiento> Personal_equipamiento { get; set; }
        public virtual DbSet<Personal_equipamiento_base> Personal_equipamiento_base { get; set; }
        public virtual DbSet<Personal_equipamiento_movimientos> Personal_equipamiento_movimientos { get; set; }
        public virtual DbSet<Personal_ere> Personal_ere { get; set; }
        public virtual DbSet<Personal_especialidades> Personal_especialidades { get; set; }
        public virtual DbSet<Personal_estados> Personal_estados { get; set; }
        public virtual DbSet<Personal_evaluacion> Personal_evaluacion { get; set; }
        public virtual DbSet<Personal_evaluacion_anual> Personal_evaluacion_anual { get; set; }
        public virtual DbSet<Personal_evaluacion_equipo> Personal_evaluacion_equipo { get; set; }
        public virtual DbSet<Personal_formacion> Personal_formacion { get; set; }
        public virtual DbSet<Personal_formacion_centros> Personal_formacion_centros { get; set; }
        public virtual DbSet<Personal_formacion_idiomas> Personal_formacion_idiomas { get; set; }
        public virtual DbSet<Personal_formacion_tipo> Personal_formacion_tipo { get; set; }
        public virtual DbSet<Personal_formacion_titulaciones> Personal_formacion_titulaciones { get; set; }
        public virtual DbSet<Personal_grupos_trabajo> Personal_grupos_trabajo { get; set; }
        public virtual DbSet<Personal_grupos_trabajo_relacion> Personal_grupos_trabajo_relacion { get; set; }
        public virtual DbSet<Personal_horarios> Personal_horarios { get; set; }
        public virtual DbSet<Personal_idiomas> Personal_idiomas { get; set; }
        public virtual DbSet<Personal_incidencias> Personal_incidencias { get; set; }
        public virtual DbSet<Personal_perfil> Personal_perfil { get; set; }
        public virtual DbSet<Personal_perfil_tareas> Personal_perfil_tareas { get; set; }
        public virtual DbSet<Personal_presencia> Personal_presencia { get; set; }
        public virtual DbSet<Personal_presencia_fotos> Personal_presencia_fotos { get; set; }
        public virtual DbSet<Personal_presencia_tipos> Personal_presencia_tipos { get; set; }
        public virtual DbSet<Personal_prima_asistencia_puntualidad> Personal_prima_asistencia_puntualidad { get; set; }
        public virtual DbSet<Personal_prima_produccion> Personal_prima_produccion { get; set; }
        public virtual DbSet<Personal_puestos_trabajo> Personal_puestos_trabajo { get; set; }
        public virtual DbSet<Personal_ramas> Personal_ramas { get; set; }
        public virtual DbSet<Personal_regimen_trabajo> Personal_regimen_trabajo { get; set; }
        public virtual DbSet<Personal_secciones> Personal_secciones { get; set; }
        public virtual DbSet<Personal_seguridad_social_epigrafes> Personal_seguridad_social_epigrafes { get; set; }
        public virtual DbSet<Personal_seguridad_social_grupo_cotizacion> Personal_seguridad_social_grupo_cotizacion { get; set; }
        public virtual DbSet<Personal_tipo_contrato> Personal_tipo_contrato { get; set; }
        public virtual DbSet<Personal_turnos> Personal_turnos { get; set; }
        public virtual DbSet<Piezas> Piezas { get; set; }
        public virtual DbSet<Planificacion_cataforesis> Planificacion_cataforesis { get; set; }
        public virtual DbSet<Planificador_informe> Planificador_informe { get; set; }
        public virtual DbSet<Posiciones> Posiciones { get; set; }
        public virtual DbSet<Precios_copias> Precios_copias { get; set; }
        public virtual DbSet<Preparacion_previa_material_unidades> Preparacion_previa_material_unidades { get; set; }
        public virtual DbSet<Preparacion_previa_material_volumen> Preparacion_previa_material_volumen { get; set; }
        public virtual DbSet<Prioridades> Prioridades { get; set; }
        public virtual DbSet<Procesos_externos> Procesos_externos { get; set; }
        public virtual DbSet<Procesos_tipos> Procesos_tipos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<Proveedores_articulos_bloqueados> Proveedores_articulos_bloqueados { get; set; }
        public virtual DbSet<Proveedores_bancos> Proveedores_bancos { get; set; }
        public virtual DbSet<Proveedores_certificaciones> Proveedores_certificaciones { get; set; }
        public virtual DbSet<Proveedores_compras_areas> Proveedores_compras_areas { get; set; }
        public virtual DbSet<Proveedores_compras_tipos> Proveedores_compras_tipos { get; set; }
        public virtual DbSet<Proveedores_confirming_tipos> Proveedores_confirming_tipos { get; set; }
        public virtual DbSet<Proveedores_cuentas_contables> Proveedores_cuentas_contables { get; set; }
        public virtual DbSet<Proveedores_departamentos> Proveedores_departamentos { get; set; }
        public virtual DbSet<Proveedores_direcciones> Proveedores_direcciones { get; set; }
        public virtual DbSet<Proveedores_graficos> Proveedores_graficos { get; set; }
        public virtual DbSet<Proveedores_precios_compra> Proveedores_precios_compra { get; set; }
        public virtual DbSet<Proveedores_presupuestos_prevision> Proveedores_presupuestos_prevision { get; set; }
        public virtual DbSet<Proveedores_procesos> Proveedores_procesos { get; set; }
        public virtual DbSet<Proveedores_sinonimos> Proveedores_sinonimos { get; set; }
        public virtual DbSet<Proveedores_transporte_expediciones> Proveedores_transporte_expediciones { get; set; }
        public virtual DbSet<Proveedores_visitas> Proveedores_visitas { get; set; }
        public virtual DbSet<Proyectos> Proyectos { get; set; }
        public virtual DbSet<Puertos_embarque> Puertos_embarque { get; set; }
        public virtual DbSet<Remesas_compras> Remesas_compras { get; set; }
        public virtual DbSet<Remesas_compras_cabecera> Remesas_compras_cabecera { get; set; }
        public virtual DbSet<Remesas_compras_detalle> Remesas_compras_detalle { get; set; }
        public virtual DbSet<Remesas_ventas> Remesas_ventas { get; set; }
        public virtual DbSet<Remesas_ventas_cabecera> Remesas_ventas_cabecera { get; set; }
        public virtual DbSet<Remesas_ventas_detalle> Remesas_ventas_detalle { get; set; }
        public virtual DbSet<Remesas_ventas_sepa> Remesas_ventas_sepa { get; set; }
        public virtual DbSet<Reparto_costes> Reparto_costes { get; set; }
        public virtual DbSet<Rutas_planificadas> Rutas_planificadas { get; set; }
        public virtual DbSet<Scheduler_configuracion> Scheduler_configuracion { get; set; }
        public virtual DbSet<Scheduler_destinatarios> Scheduler_destinatarios { get; set; }
        public virtual DbSet<Scheduler_log> Scheduler_log { get; set; }
        public virtual DbSet<Scheduler_parameters> Scheduler_parameters { get; set; }
        public virtual DbSet<Secciones_contables> Secciones_contables { get; set; }
        public virtual DbSet<Seguridad_conceptos> Seguridad_conceptos { get; set; }
        public virtual DbSet<Seguridad_grupos> Seguridad_grupos { get; set; }
        public virtual DbSet<Sentencia_sql_ejemplos> Sentencia_sql_ejemplos { get; set; }
        public virtual DbSet<Servicios> Servicios { get; set; }
        public virtual DbSet<Simulaciones> Simulaciones { get; set; }
        public virtual DbSet<Soldadura> Soldadura { get; set; }
        public virtual DbSet<Talleres> Talleres { get; set; }
        public virtual DbSet<Talleres_departamentos> Talleres_departamentos { get; set; }
        public virtual DbSet<Talleres_visitas> Talleres_visitas { get; set; }
        public virtual DbSet<Tipo_cargas> Tipo_cargas { get; set; }
        public virtual DbSet<Tipos_confirming> Tipos_confirming { get; set; }
        public virtual DbSet<Trabajos> Trabajos { get; set; }
        public virtual DbSet<Trabajos_centros> Trabajos_centros { get; set; }
        public virtual DbSet<Trabajos_personal> Trabajos_personal { get; set; }
        public virtual DbSet<Transportes_salidas> Transportes_salidas { get; set; }
        public virtual DbSet<Transportistas> Transportistas { get; set; }
        public virtual DbSet<Transportistas_departamentos> Transportistas_departamentos { get; set; }
        public virtual DbSet<Transportistas_evaluacion> Transportistas_evaluacion { get; set; }
        public virtual DbSet<Transportistas_matriculas> Transportistas_matriculas { get; set; }
        public virtual DbSet<Transportistas_visitas> Transportistas_visitas { get; set; }
        public virtual DbSet<Traspaso_maquinas_autoexpendedoras> Traspaso_maquinas_autoexpendedoras { get; set; }
        public virtual DbSet<Troqueles> Troqueles { get; set; }
        public virtual DbSet<Troqueles_articulos> Troqueles_articulos { get; set; }
        public virtual DbSet<Troqueles_articulos_proveedores> Troqueles_articulos_proveedores { get; set; }
        public virtual DbSet<Troqueles_empresas> Troqueles_empresas { get; set; }
        public virtual DbSet<Troqueles_funcion> Troqueles_funcion { get; set; }
        public virtual DbSet<Troqueles_imagenes> Troqueles_imagenes { get; set; }
        public virtual DbSet<Troqueles_inventario> Troqueles_inventario { get; set; }
        public virtual DbSet<Troqueles_mantenimiento> Troqueles_mantenimiento { get; set; }
        public virtual DbSet<Troqueles_mantenimiento_conceptos> Troqueles_mantenimiento_conceptos { get; set; }
        public virtual DbSet<Troqueles_movimientos> Troqueles_movimientos { get; set; }
        public virtual DbSet<Troqueles_stocks> Troqueles_stocks { get; set; }
        public virtual DbSet<Troqueles_tipos_funcion> Troqueles_tipos_funcion { get; set; }
        public virtual DbSet<Troqueles_tipos_movimientos> Troqueles_tipos_movimientos { get; set; }
        public virtual DbSet<Utiles> Utiles { get; set; }
        public virtual DbSet<Utiles_conjunto> Utiles_conjunto { get; set; }
        public virtual DbSet<Utiles_control> Utiles_control { get; set; }
        public virtual DbSet<Utiles_cunas_posicionamiento> Utiles_cunas_posicionamiento { get; set; }
        public virtual DbSet<Utiles_estados> Utiles_estados { get; set; }
        public virtual DbSet<Utiles_garras> Utiles_garras { get; set; }
        public virtual DbSet<Utiles_jaulas> Utiles_jaulas { get; set; }
        public virtual DbSet<Utiles_piezas> Utiles_piezas { get; set; }
        public virtual DbSet<Utiles_soldar> Utiles_soldar { get; set; }
        public virtual DbSet<Valoracion_colaboracion> Valoracion_colaboracion { get; set; }
        public virtual DbSet<Valoracion_transporte> Valoracion_transporte { get; set; }
        public virtual DbSet<Ventas_albaranes_cabecera> Ventas_albaranes_cabecera { get; set; }
        public virtual DbSet<Ventas_albaranes_carga> Ventas_albaranes_carga { get; set; }
        public virtual DbSet<Ventas_albaranes_carga_historico> Ventas_albaranes_carga_historico { get; set; }
        public virtual DbSet<Ventas_albaranes_carga_operarios> Ventas_albaranes_carga_operarios { get; set; }
        public virtual DbSet<Ventas_albaranes_carga_salidas> Ventas_albaranes_carga_salidas { get; set; }
        public virtual DbSet<Ventas_albaranes_detalle> Ventas_albaranes_detalle { get; set; }
        public virtual DbSet<Ventas_albaranes_detalle_ubicaciones> Ventas_albaranes_detalle_ubicaciones { get; set; }
        public virtual DbSet<Ventas_albaranes_embalajes> Ventas_albaranes_embalajes { get; set; }
        public virtual DbSet<Ventas_documentacion_facturacion> Ventas_documentacion_facturacion { get; set; }
        public virtual DbSet<Ventas_facturas_cabecera> Ventas_facturas_cabecera { get; set; }
        public virtual DbSet<Ventas_facturas_detalle> Ventas_facturas_detalle { get; set; }
        public virtual DbSet<Ventas_facturas_embalajes> Ventas_facturas_embalajes { get; set; }
        public virtual DbSet<Ventas_facturas_periodos_cierre> Ventas_facturas_periodos_cierre { get; set; }
        public virtual DbSet<Ventas_indicadores_comerciales> Ventas_indicadores_comerciales { get; set; }
        public virtual DbSet<Ventas_pedidos_baja_rentabilidad> Ventas_pedidos_baja_rentabilidad { get; set; }
        public virtual DbSet<Ventas_pedidos_cabecera> Ventas_pedidos_cabecera { get; set; }
        public virtual DbSet<Ventas_pedidos_detalle> Ventas_pedidos_detalle { get; set; }
        public virtual DbSet<Ventas_pedidos_embalajes> Ventas_pedidos_embalajes { get; set; }
        public virtual DbSet<Ventas_proformas_baja_rentabilidad> Ventas_proformas_baja_rentabilidad { get; set; }
        public virtual DbSet<Ventas_proformas_cabecera> Ventas_proformas_cabecera { get; set; }
        public virtual DbSet<Ventas_proformas_detalle> Ventas_proformas_detalle { get; set; }
        public virtual DbSet<Ventas_proformas_embalajes> Ventas_proformas_embalajes { get; set; }
        public virtual DbSet<Ventas_proformas_totales> Ventas_proformas_totales { get; set; }
        public virtual DbSet<Ventas_reclamaciones_cabecera> Ventas_reclamaciones_cabecera { get; set; }
        public virtual DbSet<Ventas_reclamaciones_detalle> Ventas_reclamaciones_detalle { get; set; }
        public virtual DbSet<Vinculos_externos> Vinculos_externos { get; set; }
        public virtual DbSet<Vinculos_externos_usuarios> Vinculos_externos_usuarios { get; set; }
        public virtual DbSet<Zona_seccion> Zona_seccion { get; set; }
        public virtual DbSet<Zonas_centros> Zonas_centros { get; set; }
        public virtual DbSet<Zonas_centros_secciones> Zonas_centros_secciones { get; set; }
        public virtual DbSet<Zonas_secciones_empresa> Zonas_secciones_empresa { get; set; }
        public virtual DbSet<Zonas_trabajo> Zonas_trabajo { get; set; }
        public virtual DbSet<Zonas_trabajo_edificios> Zonas_trabajo_edificios { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}