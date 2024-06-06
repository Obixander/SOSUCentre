﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SosuCentre.DataAccess;

#nullable disable

namespace SosuCentre.DataAccess.Migrations
{
    [DbContext(typeof(SosuCentreContext))]
    [Migration("20240606102453_UpdatedEntities9")]
    partial class UpdatedEntities9
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AssignmentEmployee", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("TasksAssignmentId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "TasksAssignmentId");

                    b.HasIndex("TasksAssignmentId");

                    b.ToTable("AssignmentEmployee");
                });

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("EmployeeRole");
                });

            modelBuilder.Entity("SosuCentre.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("SosuCentre.Entities.Assignment", b =>
                {
                    b.Property<int>("AssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssignmentId"));

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.HasKey("AssignmentId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Assignment");
                });

            modelBuilder.Entity("SosuCentre.Entities.CareCenter", b =>
                {
                    b.Property<int>("CareCenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareCenterId"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CareCenterId");

                    b.HasIndex("AddressId");

                    b.ToTable("CareCenters");
                });

            modelBuilder.Entity("SosuCentre.Entities.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("SosuCentre.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int?>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SosuCentre.Entities.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicineId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("SosuCentre.Entities.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("SosuCentre.Entities.Resident", b =>
                {
                    b.Property<int>("ResidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResidentId"));

                    b.Property<int?>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResidentId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("SosuCentre.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SosuCentre.Entities.SubTask", b =>
                {
                    b.Property<int>("SubTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MedicineTaskId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubTaskId"));

                    b.Property<int?>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubTaskId");

                    b.HasIndex("AssignmentId");

                    b.ToTable("SubTasks", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("SosuCentre.Entities.MedicineTask", b =>
                {
                    b.HasBaseType("SosuCentre.Entities.SubTask");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("AssignmentId1")
                        .HasColumnType("int");

                    b.Property<int?>("MedicineId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("AssignmentId1");

                    b.HasIndex("MedicineId");

                    b.ToTable("MedicineTasks", (string)null);
                });

            modelBuilder.Entity("AssignmentEmployee", b =>
                {
                    b.HasOne("SosuCentre.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SosuCentre.Entities.Assignment", null)
                        .WithMany()
                        .HasForeignKey("TasksAssignmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeRole", b =>
                {
                    b.HasOne("SosuCentre.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SosuCentre.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SosuCentre.Entities.Assignment", b =>
                {
                    b.HasOne("SosuCentre.Entities.Resident", "Resident")
                        .WithMany()
                        .HasForeignKey("ResidentId");

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("SosuCentre.Entities.CareCenter", b =>
                {
                    b.HasOne("SosuCentre.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("SosuCentre.Entities.Diagnosis", b =>
                {
                    b.HasOne("SosuCentre.Entities.Resident", null)
                        .WithMany("Diagnoses")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("SosuCentre.Entities.Employee", b =>
                {
                    b.HasOne("SosuCentre.Entities.CareCenter", "CareCenter")
                        .WithMany()
                        .HasForeignKey("CareCenterId");

                    b.Navigation("CareCenter");
                });

            modelBuilder.Entity("SosuCentre.Entities.Prescription", b =>
                {
                    b.HasOne("SosuCentre.Entities.Resident", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("SosuCentre.Entities.Resident", b =>
                {
                    b.HasOne("SosuCentre.Entities.CareCenter", null)
                        .WithMany("Residents")
                        .HasForeignKey("CareCenterId");
                });

            modelBuilder.Entity("SosuCentre.Entities.SubTask", b =>
                {
                    b.HasOne("SosuCentre.Entities.Assignment", null)
                        .WithMany("SubTasks")
                        .HasForeignKey("AssignmentId");
                });

            modelBuilder.Entity("SosuCentre.Entities.MedicineTask", b =>
                {
                    b.HasOne("SosuCentre.Entities.Assignment", null)
                        .WithMany("MedicineTasks")
                        .HasForeignKey("AssignmentId1");

                    b.HasOne("SosuCentre.Entities.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId");

                    b.HasOne("SosuCentre.Entities.SubTask", null)
                        .WithOne()
                        .HasForeignKey("SosuCentre.Entities.MedicineTask", "SubTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("SosuCentre.Entities.Assignment", b =>
                {
                    b.Navigation("MedicineTasks");

                    b.Navigation("SubTasks");
                });

            modelBuilder.Entity("SosuCentre.Entities.CareCenter", b =>
                {
                    b.Navigation("Residents");
                });

            modelBuilder.Entity("SosuCentre.Entities.Resident", b =>
                {
                    b.Navigation("Diagnoses");

                    b.Navigation("Prescriptions");
                });
#pragma warning restore 612, 618
        }
    }
}
