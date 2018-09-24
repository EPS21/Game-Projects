#include <SFML\Graphics.hpp>
#include <time.h>
using namespace sf; // the sfml namespace

int main() 
{
	RenderWindow window (VideoMode(800, 600), "SFML Asteroids");
	//Style::Resize;

	while (window.isOpen())
	{
		Event e;
		while (window.pollEvent(e))
		{
			if (e.type == Event::Closed) window.close();

			if (e.type == Event::KeyPressed)
				if (e.key.code == Keyboard::Escape) window.close();

		}

		window.clear(Color::Cyan);
		window.display();
	}

}