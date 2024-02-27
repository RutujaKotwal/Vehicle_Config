package com.example.repositories;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.entities.Invoice;

import jakarta.transaction.Transactional;

@Repository
@Transactional
public interface InvoiceRepository extends JpaRepository<Invoice, Integer> {

}
