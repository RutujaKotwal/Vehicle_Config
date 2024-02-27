package com.example.services;


import java.util.List;
import java.util.Optional;

import org.springframework.data.repository.query.Param;

import com.example.entities.Segment_master;

public interface Segmentmanager {
	
	List<Segment_master> Getallseg ();

}