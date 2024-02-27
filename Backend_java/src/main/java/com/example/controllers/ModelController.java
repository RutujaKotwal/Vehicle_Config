package com.example.controllers;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

import com.example.entities.Model_master;
import com.example.services.ModelManager;

@RestController
@CrossOrigin
public class ModelController {

	@Autowired
	private ModelManager mdl_mgr;

	@GetMapping("api/Model/{Seg_id}/{Mfg_id}")
	public List<Model_master> getVariantList(@PathVariable int Seg_id, @PathVariable int Mfg_id) {
		return mdl_mgr.getvariant(Seg_id, Mfg_id);
	}
	
	
}