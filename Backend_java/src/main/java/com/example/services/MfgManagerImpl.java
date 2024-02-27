package com.example.services;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.entities.Mfg_master;
import com.example.entities.Segment_master;
import com.example.repositories.MfgRepository;
import com.example.repositories.SegmentRepository;

@Service
public class MfgManagerImpl implements MfgManager {
	@Autowired
	private MfgRepository mgr_repo;

	@Override
	public List<Mfg_master> getallmanufacturer() {
		return mgr_repo.findAll();
	}

	
	public List<Mfg_master> getManufacturerssegid(int seg_id) {
		// TODO Auto-generated method stub
		return mgr_repo.getManufacturers(seg_id);
	}

	

}