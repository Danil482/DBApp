using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace test;

public partial class TravelAgencyContext : DbContext
{
    public TravelAgencyContext()
    {
    }

    public TravelAgencyContext(DbContextOptions<TravelAgencyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Airline> Airlines { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<ClientTicketEmployee> ClientTicketEmployees { get; set; }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<Tour> Tours { get; set; }

    public virtual DbSet<Trip> Trips { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Server=localhost; Port=5432; Database=travel_agency; UserId=postgres; Password=588228");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Airline>(entity =>
        {
            entity.HasKey(e => e.AirlineId).HasName("table1_pkey");

            entity.ToTable("airlines");

            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.NameAirline)
                .HasMaxLength(50)
                .HasColumnName("name_airline");
            entity.Property(e => e.Rating).HasColumnName("rating");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.BranchId).HasName("Branch_pkey");

            entity.ToTable("branch");

            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.Address)
                .HasMaxLength(30)
                .HasColumnName("address");
            entity.Property(e => e.Postcode)
                .HasMaxLength(30)
                .HasColumnName("postcode");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.ClientId).HasName("Client_pkey");

            entity.ToTable("client");

            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.FirstDate).HasColumnName("first_date");
            entity.Property(e => e.LastDate).HasColumnName("last_date");
            entity.Property(e => e.Passport).HasColumnName("passport");
            entity.Property(e => e.TourId).HasColumnName("tour_id");
            entity.Property(e => e.TripId).HasColumnName("trip_id");

            entity.HasOne(d => d.Tour).WithMany(p => p.Clients)
                .HasForeignKey(d => d.TourId)
                .HasConstraintName("tour_id");

            entity.HasOne(d => d.Trip).WithMany(p => p.Clients)
                .HasForeignKey(d => d.TripId)
                .HasConstraintName("trip_id");
        });

        modelBuilder.Entity<ClientTicketEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("client_ticket_employee");

            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.TicketId).HasColumnName("ticket_id");

            entity.HasOne(d => d.Client).WithMany()
                .HasForeignKey(d => d.ClientId)
                .HasConstraintName("client_id");

            entity.HasOne(d => d.Employee).WithMany()
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("employee_id");

            entity.HasOne(d => d.Ticket).WithMany()
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("ticket_id");
        });

        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.ContractId).HasName("Сontract_pkey");

            entity.ToTable("contract");

            entity.Property(e => e.ContractId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("contract_id");
            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.ClientId).HasColumnName("client_id");
            entity.Property(e => e.DepartureCity)
                .HasMaxLength(30)
                .HasColumnName("departure_city");
            entity.Property(e => e.DepartureCountry)
                .HasMaxLength(30)
                .HasColumnName("departure_country");
            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.TourCost).HasColumnName("tour_cost");
            entity.Property(e => e.TourId).HasColumnName("tour_id");

            entity.HasOne(d => d.Airline).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("airline_id");

            entity.HasOne(d => d.Employee).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("emplyee_id");

            entity.HasOne(d => d.Tour).WithMany(p => p.Contracts)
                .HasForeignKey(d => d.TourId)
                .HasConstraintName("tour_id");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("Employee_pkey");

            entity.ToTable("employee");

            entity.Property(e => e.EmployeeId).HasColumnName("employee_id");
            entity.Property(e => e.BranchId).HasColumnName("branch_id");
            entity.Property(e => e.FullName)
                .HasColumnType("character varying")
                .HasColumnName("full_name");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .HasColumnName("password");
            entity.Property(e => e.PhoneNumber)
                .HasColumnType("character varying")
                .HasColumnName("phone_number");

            entity.HasOne(d => d.Branch).WithMany(p => p.Employees)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("branch_id");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.HotelId).HasName("Hotel_pkey");

            entity.ToTable("hotel");

            entity.Property(e => e.HotelId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("hotel_id");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.HotelAddress)
                .HasMaxLength(30)
                .HasColumnName("hotel_address");
            entity.Property(e => e.NameHotel)
                .HasMaxLength(30)
                .HasColumnName("name_hotel");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("Ticket_pkey");

            entity.ToTable("ticket");

            entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.Airport)
                .HasMaxLength(50)
                .HasColumnName("airport");
            entity.Property(e => e.DepartureDate).HasColumnName("departure_date");
            entity.Property(e => e.NameTicket)
                .HasMaxLength(50)
                .HasColumnName("name_ticket");
            entity.Property(e => e.TripId).HasColumnName("trip_id");

            entity.HasOne(d => d.Airline).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("airline_id");

            entity.HasOne(d => d.Trip).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.TripId)
                .HasConstraintName("trip_id");
        });

        modelBuilder.Entity<Tour>(entity =>
        {
            entity.HasKey(e => e.TourId).HasName("Tour_pkey");

            entity.ToTable("tour");

            entity.Property(e => e.TourId)
                .UseIdentityAlwaysColumn()
                .HasColumnName("tour_id");
            entity.Property(e => e.City)
                .HasMaxLength(30)
                .HasColumnName("city");
            entity.Property(e => e.Cost).HasColumnName("cost");
            entity.Property(e => e.Country)
                .HasMaxLength(30)
                .HasColumnName("country");
            entity.Property(e => e.HotelId).HasColumnName("hotel_id");

            entity.HasOne(d => d.Hotel).WithMany(p => p.Tours)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("hotel_id");
        });

        modelBuilder.Entity<Trip>(entity =>
        {
            entity.HasKey(e => e.TripId).HasName("Trip_pkey");

            entity.ToTable("trip");

            entity.Property(e => e.TripId).HasColumnName("trip_id");
            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.Airport)
                .HasMaxLength(50)
                .HasColumnName("airport");
            entity.Property(e => e.DepartureCity)
                .HasMaxLength(50)
                .HasColumnName("departure_city");
            entity.Property(e => e.DepartureCountry)
                .HasMaxLength(50)
                .HasColumnName("departure_country");
            entity.Property(e => e.DepartureTime).HasColumnName("departure_time");
            entity.Property(e => e.DestinationCity)
                .HasMaxLength(50)
                .HasColumnName("destination_city");
            entity.Property(e => e.DestinationCountry)
                .HasMaxLength(50)
                .HasColumnName("destination_country");
            entity.Property(e => e.NumberOfSeats).HasColumnName("number_of_seats");

            entity.HasOne(d => d.Airline).WithMany(p => p.Trips)
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("airline_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
