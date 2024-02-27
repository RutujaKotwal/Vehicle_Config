package com.example.controllers;

import java.util.List;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.repository.query.Param;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

import com.example.entities.Segment_master;

import com.example.services.Segmentmanager;

@RestController
@CrossOrigin
public class SegmentController {
	@Autowired
	private Segmentmanager seg_mgr;

	@GetMapping("api/segments")
	public List<Segment_master> getseg() {
		return seg_mgr.Getallseg();
	}
	
	
}