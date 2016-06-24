///
/// Generated by bookproto
/// Do't modify this file directly
///
{% if ($package != ''): %}
namespace {%$package%} 
{
{% endif; %}
	{% foreach ($enums as $enum): %}
    public enum {%echo $prefix.$enum->getName();%} 
    {
		{% foreach ($enum->getValues() as $field): %}
    	{%echo $field->getName()%} = {%echo $field->getValue()%},
		{% endforeach; %}
	}

	{% endforeach; %}
{% if ($package != ''): %}
}
{% endif; %}