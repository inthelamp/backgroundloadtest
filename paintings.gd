extends Node2D


func OnSwitchPressed():
	$switch.hide()
	background_load.load_scene("res://sculptures.tscn")
