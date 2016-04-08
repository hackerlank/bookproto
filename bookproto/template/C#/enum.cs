///
/// Generate by bookproto
/// Do't modify this file directly
///
namespace {%$package%} 
{
	{% foreach ($enums as $enum): %}
    public enum {%echo $prefix.$enum->getName();%} 
    {
		{% foreach ($enum->getValues() as $field): %}
    	{%echo $field->getName()%} = {%echo $field->getValue()%},
		{% endforeach; %}
	}

	{% endforeach; %}
}