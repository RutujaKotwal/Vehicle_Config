package com.example.controllers;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;
import java.util.*;

import com.example.entities.Mfg_master;
import com.example.services.MfgManager;
@RestController
@CrossOrigin
public class ManufacturerController {
	
	@Autowired
	private MfgManager mfr_mgr;
	
	@GetMapping("api/mfgbyid/{Seg_id}")
	public List<Mfg_master> getmfgbysegid(@PathVariable int Seg_id){
		return  mfr_mgr.getManufacturerssegid(Seg_id);
	}
	
	@GetMapping("api/allmfg")
	public List<Mfg_master> getmfglist()
	{
		return mfr_mgr.getallmanufacturer();
	}

}