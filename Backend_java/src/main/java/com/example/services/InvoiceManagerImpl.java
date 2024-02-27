package com.example.services;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.entities.Invoice;
import com.example.repositories.InvoiceRepository;
@Service
public class InvoiceManagerImpl implements InvoiceManager {
	@Autowired
	private InvoiceRepository invoiceRepository;

	@Override
	public void createInvoice(Invoice invoice) {
		// TODO Auto-generated method stub
		invoiceRepository.save(invoice);
	}

}
