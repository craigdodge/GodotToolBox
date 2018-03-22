extends Timer

func _ready():
	pass

func _on_GDScriptTimer_timeout():
	get_node("../Log").Info("Hello from GDScriptTimer!")
