﻿// <auto-generated />
using System;
using BilHealth.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NodaTime;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BilHealth.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BilHealth.Model.Announcement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Instant>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("BilHealth.Model.Appointment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("ApprovalStatus")
                        .HasColumnType("integer");

                    b.Property<bool>("Attended")
                        .HasColumnType("boolean");

                    b.Property<bool>("Cancelled")
                        .HasColumnType("boolean");

                    b.Property<Guid>("CaseId")
                        .HasColumnType("uuid");

                    b.Property<Instant>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Instant>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("RequestedById")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("RequestedById");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("BilHealth.Model.AppointmentVisit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AppointmentId")
                        .HasColumnType("uuid");

                    b.Property<double?>("BPM")
                        .HasColumnType("double precision");

                    b.Property<double?>("BloodPressure")
                        .HasColumnType("double precision");

                    b.Property<double?>("BodyTemperature")
                        .HasColumnType("double precision");

                    b.Property<Instant>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AppointmentId")
                        .IsUnique();

                    b.ToTable("AppointmentVisits");
                });

            modelBuilder.Entity("BilHealth.Model.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("BilHealth.Model.Case", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Instant>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("DoctorUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PatientUserId")
                        .HasColumnType("uuid");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DoctorUserId");

                    b.HasIndex("PatientUserId");

                    b.ToTable("Cases");
                });

            modelBuilder.Entity("BilHealth.Model.CaseMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CaseId")
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Instant>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.ToTable("CaseMessage");
                });

            modelBuilder.Entity("BilHealth.Model.CaseSystemMessage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CaseId")
                        .HasColumnType("uuid");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Instant>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.ToTable("CaseSystemMessage");
                });

            modelBuilder.Entity("BilHealth.Model.DomainUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AppUserId")
                        .HasColumnType("uuid");

                    b.Property<LocalDate?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId")
                        .IsUnique();

                    b.ToTable("DomainUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("DomainUser");
                });

            modelBuilder.Entity("BilHealth.Model.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Instant>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Read")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("ReferenceId1")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ReferenceId2")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("BilHealth.Model.Prescription", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CaseId")
                        .HasColumnType("uuid");

                    b.Property<Instant>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("DoctorUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Item")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("DoctorUserId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("BilHealth.Model.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("BilHealth.Model.TestResult", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Instant>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("PatientUserId")
                        .HasColumnType("uuid");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PatientUserId");

                    b.ToTable("TestResults");
                });

            modelBuilder.Entity("BilHealth.Model.TriageRequest", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("ApprovalStatus")
                        .HasColumnType("integer");

                    b.Property<Guid>("CaseId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("DoctorUserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("NurseUserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CaseId");

                    b.HasIndex("DoctorUserId");

                    b.HasIndex("NurseUserId");

                    b.ToTable("TriageRequests");
                });

            modelBuilder.Entity("BilHealth.Model.Vaccination", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Instant?>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("PatientUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("PatientUserId");

                    b.ToTable("Vaccinations");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BilHealth.Model.Admin", b =>
                {
                    b.HasBaseType("BilHealth.Model.DomainUser");

                    b.HasDiscriminator().HasValue("Admin");
                });

            modelBuilder.Entity("BilHealth.Model.Doctor", b =>
                {
                    b.HasBaseType("BilHealth.Model.DomainUser");

                    b.Property<int>("Campus")
                        .HasColumnType("integer");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("Doctor");
                });

            modelBuilder.Entity("BilHealth.Model.Nurse", b =>
                {
                    b.HasBaseType("BilHealth.Model.DomainUser");

                    b.HasDiscriminator().HasValue("Nurse");
                });

            modelBuilder.Entity("BilHealth.Model.Patient", b =>
                {
                    b.HasBaseType("BilHealth.Model.DomainUser");

                    b.Property<bool>("Blacklisted")
                        .HasColumnType("boolean");

                    b.Property<int>("BloodType")
                        .HasColumnType("integer");

                    b.Property<double?>("BodyHeight")
                        .HasColumnType("double precision");

                    b.Property<double?>("BodyWeight")
                        .HasColumnType("double precision");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("BilHealth.Model.Staff", b =>
                {
                    b.HasBaseType("BilHealth.Model.DomainUser");

                    b.HasDiscriminator().HasValue("Staff");
                });

            modelBuilder.Entity("BilHealth.Model.Appointment", b =>
                {
                    b.HasOne("BilHealth.Model.Case", "Case")
                        .WithMany("Appointments")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilHealth.Model.DomainUser", "RequestedBy")
                        .WithMany()
                        .HasForeignKey("RequestedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("RequestedBy");
                });

            modelBuilder.Entity("BilHealth.Model.AppointmentVisit", b =>
                {
                    b.HasOne("BilHealth.Model.Appointment", "Appointment")
                        .WithOne("Visit")
                        .HasForeignKey("BilHealth.Model.AppointmentVisit", "AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Appointment");
                });

            modelBuilder.Entity("BilHealth.Model.Case", b =>
                {
                    b.HasOne("BilHealth.Model.Doctor", "DoctorUser")
                        .WithMany("Cases")
                        .HasForeignKey("DoctorUserId");

                    b.HasOne("BilHealth.Model.Patient", "PatientUser")
                        .WithMany("Cases")
                        .HasForeignKey("PatientUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoctorUser");

                    b.Navigation("PatientUser");
                });

            modelBuilder.Entity("BilHealth.Model.CaseMessage", b =>
                {
                    b.HasOne("BilHealth.Model.Case", "Case")
                        .WithMany("Messages")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");
                });

            modelBuilder.Entity("BilHealth.Model.CaseSystemMessage", b =>
                {
                    b.HasOne("BilHealth.Model.Case", "Case")
                        .WithMany("SystemMessages")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");
                });

            modelBuilder.Entity("BilHealth.Model.DomainUser", b =>
                {
                    b.HasOne("BilHealth.Model.AppUser", "AppUser")
                        .WithOne("DomainUser")
                        .HasForeignKey("BilHealth.Model.DomainUser", "AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("BilHealth.Model.Prescription", b =>
                {
                    b.HasOne("BilHealth.Model.Case", "Case")
                        .WithMany("Prescriptions")
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilHealth.Model.Doctor", "DoctorUser")
                        .WithMany()
                        .HasForeignKey("DoctorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("DoctorUser");
                });

            modelBuilder.Entity("BilHealth.Model.TestResult", b =>
                {
                    b.HasOne("BilHealth.Model.Patient", "PatientUser")
                        .WithMany("TestResults")
                        .HasForeignKey("PatientUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PatientUser");
                });

            modelBuilder.Entity("BilHealth.Model.TriageRequest", b =>
                {
                    b.HasOne("BilHealth.Model.Case", "Case")
                        .WithMany()
                        .HasForeignKey("CaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilHealth.Model.Doctor", "DoctorUser")
                        .WithMany()
                        .HasForeignKey("DoctorUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilHealth.Model.Nurse", "NurseUser")
                        .WithMany("TriageRequests")
                        .HasForeignKey("NurseUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Case");

                    b.Navigation("DoctorUser");

                    b.Navigation("NurseUser");
                });

            modelBuilder.Entity("BilHealth.Model.Vaccination", b =>
                {
                    b.HasOne("BilHealth.Model.Patient", "PatientUser")
                        .WithMany("Vaccinations")
                        .HasForeignKey("PatientUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PatientUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("BilHealth.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("BilHealth.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("BilHealth.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("BilHealth.Model.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BilHealth.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("BilHealth.Model.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BilHealth.Model.Appointment", b =>
                {
                    b.Navigation("Visit");
                });

            modelBuilder.Entity("BilHealth.Model.AppUser", b =>
                {
                    b.Navigation("DomainUser")
                        .IsRequired();
                });

            modelBuilder.Entity("BilHealth.Model.Case", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Messages");

                    b.Navigation("Prescriptions");

                    b.Navigation("SystemMessages");
                });

            modelBuilder.Entity("BilHealth.Model.Doctor", b =>
                {
                    b.Navigation("Cases");
                });

            modelBuilder.Entity("BilHealth.Model.Nurse", b =>
                {
                    b.Navigation("TriageRequests");
                });

            modelBuilder.Entity("BilHealth.Model.Patient", b =>
                {
                    b.Navigation("Cases");

                    b.Navigation("TestResults");

                    b.Navigation("Vaccinations");
                });
#pragma warning restore 612, 618
        }
    }
}
